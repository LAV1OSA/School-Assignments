using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BookstoreApp.Annotations;
using BookstoreApp.Dto;
using BookStoreDb;
using BookStoreDb.Core;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookstoreApp.ViewModels
{
    public class AddBookViewModel : INotifyPropertyChanged
    {
        private string _bookTitleInput;
        private string _bookIsbnInput;
        private string _bookPriceInput;
        private DateTime _datePublishedInput;
        private string _bookPagesInput;
        private string _publisherSearchText;
        private string _authorSearchText;
        private BookStoreLiteContext _context;
        private PublisherName _selectedPublisher;
        private BookAuthor _selectedAuthor;
        private BookAuthor _selectedAuthorOnList;



        public ObservableCollection<BookAuthor> Authors { get; set; } = new();
        public ObservableCollection<PublisherName> Publishers { get; set; } = new();
        public ObservableCollection<BookAuthor> AuthorList { get; set; } = new();

        public NewBookDto NewBookDto { get; set; } = new();


        public string ErrorsInText { get; set; }

        public PublisherName SelectedPublisher
        {
            get => _selectedPublisher;
            set
            {
                _selectedPublisher = value;
                NewBookDto.Publisher = value;
                OnPropertyChanged();
                Check();
            }
        }

        public BookAuthor SelectedAuthorOnList
        {
            get => _selectedAuthorOnList;
            set
            {
                _selectedAuthorOnList = value;
                OnPropertyChanged();
                Check();
            }
        }
        public BookAuthor SelectedAuthor
        {
            get => _selectedAuthor;
            set
            {
                _selectedAuthor = value;
                OnPropertyChanged();
                Check();
            }
        }

        public string BookTitleInput
        {
            get
            {
                return _bookTitleInput;
            }
            set
            {
                _bookTitleInput = value;
                NewBookDto.Title = value;
                OnPropertyChanged();
                Check();
            }
        }

        public string BookIsbnInput
        {
            get => _bookIsbnInput;
            set
            {
                _bookIsbnInput = value;
                NewBookDto.ISBN = _bookIsbnInput;
                OnPropertyChanged();
                Check();
            }
        }

        public string BookPriceInput
        {
            get => _bookPriceInput;
            set
            {
                _bookPriceInput = value;
                NewBookDto.Price = float.Parse(value);
                OnPropertyChanged();
                Check();

            }
        }

        public DateTime DatePublishedInput
        {
            get => _datePublishedInput;
            set
            {
                _datePublishedInput = value;
                NewBookDto.DatePublished = value;
                OnPropertyChanged();
                Check();
            }
        }

        public string BookPagesInput
        {
            get => _bookPagesInput;
            set
            {
                _bookPagesInput = value;
                NewBookDto.Pages = int.Parse(_bookPagesInput);
                OnPropertyChanged();
                Check();

            }
        }

        public string PublisherSearchText
        {
            get => _publisherSearchText;
            set
            {
                _publisherSearchText = value;
                FilterPublishers();
            }
        }

        public string AuthorSearchText
        {
            get => _authorSearchText;
            set
            {
                _authorSearchText = value; 

                FilterAuthors();
            }
        }

        public AddBookViewModel(BookStoreLiteContext context)
        {
            _context = context;
        }

        public void AddAuthorToList()
        {
            if (_selectedAuthor == null) return;
            AuthorList.Add(_selectedAuthor); 
            NewBookDto.Authors.Add(_selectedAuthor);
            Check();
        }
        public void RemoveAuthorFromList()
        {
            AuthorList.Remove(_selectedAuthorOnList);
            NewBookDto.Authors.Add(_selectedAuthorOnList);
            Check();
        }
        public void IncreaseHierarchy()
        {
            var index = AuthorList.IndexOf(_selectedAuthorOnList);

            if (index == 0) return;
            if (_selectedAuthorOnList == null) return;
            
            AuthorList.Move(index, index - 1);
        }
        public void DecreaseHierarchy()
        {
            var index = AuthorList.IndexOf(_selectedAuthorOnList);

            if (index == AuthorList.Count-1) return;
            if (_selectedAuthorOnList == null) return;
            AuthorList.Move(index, index +1);
        }

        public void LoadPublishers()
        {
            FilterPublishers();
        }

        private void FilterPublishers()
        {
            string search = PublisherSearchText?.ToLowerInvariant() ?? string.Empty;

            var query = _context.Publishers
                .Where(c => c.Name.ToLower().Contains(search));

            var books = query
                .OrderBy(c => c.Name)
                .Select(c => new PublisherName(c.PublisherId, c.Name))
                .ToList();
            
            Publishers.Clear();

            foreach (var item in books) Publishers.Add(item);
        }

        public void LoadAuthors()
        {
            FilterAuthors();
        }

        private void FilterAuthors()
        {
            string search = AuthorSearchText?.ToLowerInvariant() ?? string.Empty;

            var query = _context.Authors
                .Include(c=>c.Wrotes.Take(1))
                .Where(c => c.Name.ToLower().Contains(search));
                
            
            var books = query
                .OrderBy(c => c.Name)
                .Select(c => new BookAuthor(c.AuthorId,c.Name,c.Address,50))
                .ToList();

            Authors.Clear();

            foreach (var item in books) Authors.Add(item);
        }

        public void Check()
        {
            NewBookDto.Check();

            ErrorsInText = NewBookDto.ErrorsInText;

            OnPropertyChanged(nameof(ErrorsInText));
        }

        public void AddBook()
        {
            NewBookDto newBook = new NewBookDto();

            newBook.Title = _bookTitleInput;
            newBook.ISBN = _bookIsbnInput;
            newBook.DatePublished = _datePublishedInput;
            newBook.Pages = int.Parse(_bookPagesInput);
            newBook.Publisher = SelectedPublisher;

            /*_context.Set<Book>().Add(book);
            _context.SaveChanges();
            foreach (var author in AuthorList)
            {
                var wrote = new Wrote();
                wrote.BookId = book.BookId;
                wrote.AuthorId = author.AuthorId;
                wrote.RoyaltyRate = float.Parse(author.RoyaltyInString);

                _context.Set<Wrote>().Add(wrote);

            }
            _context.SaveChanges();*/
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
