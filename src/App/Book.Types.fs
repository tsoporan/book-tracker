// Book Types

type BookId = Undefined
type AuthorId = Undefined

type BookStatus =  Reading | Paused | Finished

type Author = {
    Id: AuthorId
    FirstName: string
    MiddleName: string option
    LastName: string
}

type Book = {
    Id: BookId
    Title: string
    Author: Author
    Status: BookStatus
    IsActive: bool
    Pages: int
    CurrentPage: int
    DateAdded: int
}

type AuthorInput = {
    Name: string
}

type BookInput = {
    Title: string
    Author: AuthorInput
}

type ValidationError = {
    FieldName: string
    ErrorMessage: string
}

type BookCreatedEvents = {
    CreatedBook: Undefined
}

// Other errors might be useful later on, for now just validation
type BookCreateFailed =
    | ValidationError of ValidationError list

// The output of creation is a Result of either the creation event or the errors
type CreateBook = UnvalidatedBook -> Result<BookCreatedEvents, BookCreateFailed>