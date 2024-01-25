import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Book } from './Responses/Book';
import { Author } from './Responses/Author';
import { PublishingHouse } from './Responses/PublishingHouse';
import './App.css';

type BookListProps = {
  books: Book[];
  setBooks: (books: Book[]) => void;
};
const BookList = ({books,setBooks}:BookListProps) => {
  useEffect(() => {
    const fetchBooks = async () => {
      try {
        const response = await axios.get('https://localhost:7289/Book');
        setBooks(response.data);
      } catch (error) {
        console.error('Error fetching books', error);
      }
    };
    fetchBooks();
  }, []);

  useEffect(() => {
    console.log('Books:', books);
  }, [books]);

  return (
    <div className='bookList'>
      <h1>Book List</h1>
      <ul>
        {books.slice().reverse().map((book) => (
          <li key={book.id}>
            {book.title}
          </li>
        ))}
      </ul>
    </div>
  );
};

const CreateBookForm = ({setBooks}:BookListProps) => {
  const [formData, setFormData] = useState({
    title: '',
    // Add other fields as needed
  });

  const handleInputChange = (e:any) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleFormSubmit = async (e:any) => {
    e.preventDefault();

    try {
      const response = await axios.post('https://localhost:7289/Book', formData);
      console.log('Book created:', response.data);

      const updatedBooksResponse = await axios.get('https://localhost:7289/Book');
      setBooks(updatedBooksResponse.data);
    } catch (error) {
      console.error('Error creating Book', error);
    }
  };

  return (
    <div className='bookCreate'>
      <h1>Create Book</h1>
      <form onSubmit={handleFormSubmit}>
        <label>
          Name:
          <input
            type="text"
            name="title"
            value={formData.title}
            onChange={handleInputChange}
          />
        </label>
        <br />
        <button type="submit">Create Book</button>
      </form>
    </div>
  );
};

type AuthorListProps = {
  authors: Author[];
  setAuthors: (authors: Author[]) => void;
};
const AuthorList = ({authors,setAuthors}:AuthorListProps) => {
  useEffect(() => {
    const fetchAuthors = async () => {
      try {
        const response = await axios.get('https://localhost:7289/Author');
        setAuthors(response.data);
      } catch (error) {
        console.error('Error fetching authors', error);
      }
    };
    fetchAuthors();
  }, []);

  useEffect(() => {
    console.log('Authors:', authors);
  }, [authors]);

  return (
    <div className='authorList'>
      <h1>Author List</h1>
      <ul>
        {authors.slice().reverse().map((author) => (
          <li key={author.id}>
            {author.name}
          </li>
        ))}
      </ul>
    </div>
  );
};

const CreateAuthorForm = ({setAuthors}:AuthorListProps) => {
  const [formData, setFormData] = useState({
    name: '',
    // Add other fields as needed
  });

  const handleInputChange = (e:any) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleFormSubmit = async (e:any) => {
    e.preventDefault();

    try {
      const response = await axios.post('https://localhost:7289/Author', formData);
      console.log('Author created:', response.data);

      const updatedBooksResponse = await axios.get('https://localhost:7289/Author');
      setAuthors(updatedBooksResponse.data);
    } catch (error) {
      console.error('Error creating book', error);
    }
  };

  return (
    <div className='authorCreate'>
      <h1>Create Author</h1>
      <form onSubmit={handleFormSubmit}>
        <label>
          Name:
          <input
            type="text"
            name="name"
            value={formData.name}
            onChange={handleInputChange}
          />
        </label>
        <br />
        <button type="submit">Create Author</button>
      </form>
    </div>
  );
};

type PublishingHouseListProps = {
  publishingHouses: PublishingHouse[];
  setPublishingHouses: (publishingHouses: PublishingHouse[]) => void;
};
const PublishingHouseList = ({publishingHouses,setPublishingHouses}:PublishingHouseListProps) => {
  useEffect(() => {
    const fetchPublishingHouses = async () => {
      try {
        const response = await axios.get('https://localhost:7289/PublishingHouse');
        setPublishingHouses(response.data);
      } catch (error) {
        console.error('Error fetching publishingHouses', error);
      }
    };
    fetchPublishingHouses();
  }, []);

  useEffect(() => {
    console.log('PublishingHouses:', publishingHouses);
  }, [publishingHouses]);

  return (
    <div className='PHList'>
      <h1>PublishingHouse List</h1>
      <ul>
        {publishingHouses.slice().reverse().map((publishingHouse) => (
          <li key={publishingHouse.id}>
            {publishingHouse.name}
          </li>
        ))}
      </ul>
    </div>
  );
};

const CreatePublishingHouseForm = ({setPublishingHouses}:PublishingHouseListProps) => {
  const [formData, setFormData] = useState({
    name: '',
    // Add other fields as needed
  });

  const handleInputChange = (e:any) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleFormSubmit = async (e:any) => {
    e.preventDefault();

    try {
      const response = await axios.post('https://localhost:7289/PublishingHouse', formData);
      console.log('PublishingHouse created:', response.data);

      const updatedbooksResponse = await axios.get('https://localhost:7289/PublishingHouse');
      setPublishingHouses(updatedbooksResponse.data);
    } catch (error) {
      console.error('Error creating book', error);
    }
  };

  return (
    <div className='PHCreate'>
      <h1>Create PublishingHouse</h1>
      <form onSubmit={handleFormSubmit}>
        <label>
          Name:
          <input
            type="text"
            name="name"
            value={formData.name}
            onChange={handleInputChange}
          />
        </label>
        <br />
        <button type="submit">Create PublishingHouse</button>
      </form>
    </div>
  );
};



const BookPage = () => {
  const [books, setBooks] = useState<Book[]>([]);

  return (
    <>
    <CreateBookForm setBooks={setBooks} books={books}/>
    <BookList setBooks={setBooks} books={books}/>
    </>
  );
};

const AuthorPage = () => {
  const [authors, setAuthors] = useState<Author[]>([]);

  return (
    <>
    <CreateAuthorForm setAuthors={setAuthors} authors={authors}/>
    <AuthorList setAuthors={setAuthors} authors={authors}/>
    </>
  );
}

const PublishingHousePage = () => {
  const [publishingHouses, setPublishingHouses] = useState<PublishingHouse[]>([]);

  return (
    <>
    <CreatePublishingHouseForm setPublishingHouses={setPublishingHouses} publishingHouses={publishingHouses}/>
    <PublishingHouseList setPublishingHouses={setPublishingHouses} publishingHouses={publishingHouses}/>
    </>
  );
}
const App = () => {
  return (
    <div>
      <BookPage />  
      <AuthorPage />
      <PublishingHousePage />
    </div>
  );
};

export default App;