using Entities;
using DbEntities;

namespace Extensions;

public static class TransactionExtentions
{
    public static BookTransactionDto BookTransctionToDto(this DbBookTransaction bookTransaction)
        => new()
        {
            Id = bookTransaction.Id,
            BookId = bookTransaction.BookId,
            ReaderId = bookTransaction.ReaderId,
            IssuedAt = bookTransaction.IssuedAt,
            ReturnedAt = bookTransaction.ReturnedAt,
            AccruedFine = bookTransaction.AccruedFine,
            IsReturned = bookTransaction.IsReturned
        };

    public static DbBookTransaction DtoToBookTransaction(this BookTransactionDto bookTransaction)
        => new()
        {
            Id = bookTransaction.Id,
            BookId = bookTransaction.BookId,
            ReaderId = bookTransaction.ReaderId,
            IssuedAt = bookTransaction.IssuedAt,
            ReturnedAt = bookTransaction.ReturnedAt,
            AccruedFine = bookTransaction.AccruedFine,
            IsReturned = bookTransaction.IsReturned
        };
}       
