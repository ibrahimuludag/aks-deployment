using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Extensions
{
    public static class BookExtensions
    {
        public static BookDetail ToDetailModel(this Book book)
        {
            return new BookDetail
            {
                Author = book.Author,
                Id = book.Id,
                Name = book.Name
            };
        }
    }
}
