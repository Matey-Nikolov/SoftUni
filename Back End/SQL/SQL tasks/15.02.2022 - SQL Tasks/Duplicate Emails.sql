SELECT DISTINCT d.Email
From DuplicateEmails AS d, DuplicateEmails AS e
WHERE d.Id <> e.Id AND d.Email = e.Email