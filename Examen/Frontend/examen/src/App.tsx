import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Student } from './Response/Student';
import './App.css';

type StudentListProps = {
  students: Student[];
  setStudents: (students: Student[]) => void;
};
const StudentList = ({students,setStudents}:StudentListProps) => {

  const handleUpdatePoints = async (name: string) => {
    try {
      const response = await axios.patch(`https://localhost:7289/Student/${name}`);
      console.log('Student updated:', response.data);

      const updatedStudentsResponse = await axios.get('https://localhost:7289/Student');
      setStudents(updatedStudentsResponse.data);
    } catch (error) {
      console.error('Error updating student points', error);
    }
  };

  const handleDeleteStudent = async (name: string) => {
    try {
      const response = await axios.delete(`https://localhost:7289/Student/${name}`);
      console.log('Student deleted:', response.data);

      const updatedStudentsResponse = await axios.get('https://localhost:7289/Student');
      setStudents(updatedStudentsResponse.data);
    } catch (error) {
      console.error('Error deleting student', error);
    }
  };

  useEffect(() => {
    const fetchStudents = async () => {
      try {
        const response = await axios.get('https://localhost:7289/Student');
        setStudents(response.data);
      } catch (error) {
        console.error('Error fetching students', error);
      }
    };
    fetchStudents();
  }, []);

  useEffect(() => {
    console.log('Students:', students);
  }, [students]);

  return (
    <div>
      <h1>Student List</h1>
      <ul>
        {students.slice().reverse().map((student) => (
          <li key={student.id}>
            <button onClick={() => handleDeleteStudent(student.name)}>Delete Student</button>
            {student.name} {student.points}
            <button onClick={() => handleUpdatePoints(student.name)}>Add one point</button>
          </li>
        ))}
      </ul>
    </div>
  );
};

const CreateStudentForm = ({setStudents}:StudentListProps) => {
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
      const response = await axios.post('https://localhost:7289/Student', formData);
      console.log('Student created:', response.data);

      const updatedStudentsResponse = await axios.get('https://localhost:7289/Student');
      setStudents(updatedStudentsResponse.data);
    } catch (error) {
      console.error('Error creating student', error);
    }
  };

  return (
    <div>
      <h1>Create Student</h1>
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
        <button type="submit">Create Student</button>
      </form>
    </div>
  );
};

const StudentPage = () => {
  const [students, setStudents] = useState<Student[]>([]);

  return (
    <>
    <CreateStudentForm setStudents={setStudents} students={students}/>
    <StudentList setStudents={setStudents} students={students}/>
    </>
  );
};

const App = () => {
  return (
    <div>
      <StudentPage />
    </div>
  );
};

export default App;