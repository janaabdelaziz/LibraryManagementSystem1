USE LibraryDB;
GO

SELECT 
    B.Title,
    BC.CopyID,
    R.ReservationDate,
    R.Status
FROM RESERVATION R
JOIN BOOK_COPIES BC ON R.CopyID = BC.CopyID
JOIN BOOKS B ON BC.BookID = B.BookID
WHERE R.UserID = 1
ORDER BY R.ReservationDate DESC;
GO