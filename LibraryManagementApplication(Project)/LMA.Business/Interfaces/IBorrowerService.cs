using LMA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA.Business.Interfaces
{
    public interface IBorrowerService
    {
        IEnumerable<Borrower> GetAllBorrowers();
        Borrower GetBorrowerById(int id);
        void AddBorrower(Borrower borrower);
        void UpdateBorrower(Borrower borrower);
        void DeleteBorrower(int id);
        IEnumerable<Book> GetBorrowedBooksByBorrower(int borrowerId);
    }
}
