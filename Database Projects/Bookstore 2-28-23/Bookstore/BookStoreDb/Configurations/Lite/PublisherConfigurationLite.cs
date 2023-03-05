﻿using BookStoreDb.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreDb.Configurations.Lite;

public class PublisherConfigurationLite: IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> d)
    {
        d.ToTable("Publisher");

        var publishers = ExtractFromCsv();

        foreach (var item in publishers)
        {
            d.HasData(item);
        }
    }

    private List<Publisher> ExtractFromCsv()
    {
        var sr = new StreamReader(@"SeedData\Publisher.csv");
        var list = new List<Publisher>();

        var line = sr.ReadLine();
        int publisherId = 0;

        while (line != null)
        {
            var split = line.Split(',');

            var book = new Publisher
            {
                PublisherId = ++publisherId,
                Name = split[0],
            };

            list.Add(book);

            line = sr.ReadLine();
        }

        return list;
    }
}
