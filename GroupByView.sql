CREATE DATABASE GroupByPractise
USE GroupByPractise

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
Point INT CHECK(Point >=0 AND Point <=100),
Age INT CHECK(Age>10 AND Age<65)
)

CREATE TABLE Subjects(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE StudentSubjects(
StudentId INT NOT NULL REFERENCES Students(Id),
SubjectId INT NOT NULL REFERENCES Subjects(Id)
)

CREATE VIEW GetStudentsSubjects
AS
SELECT s.Name +' '+ s.Surname AS FullName,sub.Name AS Subject
FROM Students AS s
JOIN StudentSubjects AS ss
ON s.Id=ss.StudentId
JOIN Subjects as sub
ON ss.SubjectId=sub.Id


Select FullName,Count(Subject) FROM GetStudentsSubjects 
GROUP BY FullName



SELECT s.Name +' '+ s.Surname AS FullName,COUNT(sub.Name) AS Subject
FROM Students AS s
JOIN StudentSubjects AS ss
ON s.Id=ss.StudentId
JOIN Subjects as sub
ON ss.SubjectId=sub.Id
GROUP BY s.Name, s.Surname
HAVING COUNT(sub.Name)>=2
