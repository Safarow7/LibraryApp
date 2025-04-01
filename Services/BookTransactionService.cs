using System.Net;
using System.Runtime.Serialization;
using DateBase;
using DbEntities;

namespace Services;

public class BookTransactionService : IBookTransactionService
{
    public Guid Create(DbBookTransaction bookTransaction)
    {
        DbContext._bookTransactions[bookTransaction.Id] = bookTransaction;
        return bookTransaction.Id;
    }

    public bool Update(DbBookTransaction newBookTransaction)
    {
        if (DbContext._bookTransactions.TryGetValue(newBookTransaction.Id, out _))
        {
            DbContext._bookTransactions[newBookTransaction.Id] = newBookTransaction;
            return true;
        }
        return false;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._bookTransactions.TryGetValue(id, out _))
        {
            DbContext._bookTransactions.Remove(id);
            return true;
        }
        return false;
    }

    public List<DbBookTransaction> Get() => DbContext._bookTransactions.Values.ToList();

    public DbBookTransaction? Get(Guid id)
    {
        DbContext._bookTransactions.TryGetValue(id, out DbBookTransaction? bookTransaction);
        return bookTransaction;
        
    }
}