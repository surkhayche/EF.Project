using LMA.Business.Interfaces;
using LMA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA.Business.Implementations
{
    public class BorrowerService : IBorrowerService
    {
        private readonly LibraryContext _context;

        public BorrowerService(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Borrower> GetAllBorrowers()
        {
            return _context.Borrowers.ToList();
        }

        public Borrower GetBorrowerById(int id)
        {
            return _context.Borrowers.Find(id);
        }

        public void AddBorrower(Borrower borrower)
        {
            _context.Borrowers.Add(borrower);
            _context.SaveChanges();
        }

        public void UpdateBorrower(Borrower borrower)
        {
            _context.Borrowers.Update(borrower);
            _context.SaveChanges();
        }

        public void DeleteBorrower(int id)
        {
            var borrower = _context.Borrowers.Find(id);
            if (borrower != null)
            {
                _context.Borrowers.Remove(borrower);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Book> GetBorrowedBooksByBorrower(int borrowerId)
        {
            return _context.Loans
                .Where(l => l.BorrowerId == borrowerId)
                .SelectMany(l => l.LoanItems)
                .Select(li => li.Book)
                .ToList();
        }
    }
}
