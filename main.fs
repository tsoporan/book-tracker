type BookStatus =  Reading | Paused | Finished

type Author = {
    FirstName: string;
    MiddleName: string option;
    LastName: string;
}

type Book = {
    Title: string;
    Author: Author;
    Status: BookStatus;
    IsActive: bool;
    Pages: int;
    CurrentPage: int;
}