﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreDb.Core;

namespace BookstoreApp.Dto
{
    public class BookTitle
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public BookTitle(int bookId, string title)
        {
            BookId = bookId;
            Title = title;
        }
    }

    public class Price
    {
        private float _data;
        private static string _format = "{0:N2}";

        public Price(float data)
        {
            _data = data;
        }

        public string Data
        {
            get
            {
                return string.Format(_format, _data);
            }
        }

        public static void SetFormat(string format)
        {
            _format = format;
        }

        public override string ToString()
        {
            return Data;
        }
    }

    public class BookDetails
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public Price Price { get; set; }
        public string DatePublished { get; set; }
        public string Pages { get; set; }
        public string Age { get; set; }

        public string PublisherName { get; set; }

        public string AuthorInString { get; set; }

        public List<AuthorWrote> AuthorList { get; set; } = new();

        public BookDetails(Book book)
        {
            if (book.PublisherLink == null)
            {
                throw new InvalidOperationException("Publisher must be loaded for this book." +
                                                    "Either use explicit or eager loading.");
            }

            if (book.Wrotes == null)
            {
                throw new InvalidOperationException("Wrotes must be loaded for this book." +
                                                    "Either use explicit or eager loading.");
            }

            Isbn = book.Isbn;
            Title = book.Title;
            Price = new Price(book.Price);
            DatePublished = $"{book.DatePublished:dd MMM yyyy}";
            Pages = $"{book.NumPages:N0}";
            Age = $"{book.DaysOld:N0}";

            PublisherName = book.PublisherLink.Name;

            // load the authors
            var sb = new List<string>();

            AuthorList.Clear();
            foreach (var i in book.Wrotes)
            {
                if (i.AuthorLink == null) continue;

                sb.Add(i.AuthorLink.Name);
                string royaltyRate = $"{i.RoyaltyRate:N2}";

                AuthorList.Add(new AuthorWrote(i.AuthorLink.Name, i.AuthorLink.Address, royaltyRate));
            }

            if (sb.Count == 0)
                AuthorInString = "Unknown Author";
            else
                AuthorInString = string.Join(",", sb);

        }
    }

    public class AuthorWrote
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string RoyaltyRate { get; set; }

        public AuthorWrote(string name, string address, string royaltyRate)
        {
            Name = name;
            Address = address;
            RoyaltyRate = royaltyRate;
        }
    }
}
