-- 1. Teachers
INSERT INTO Teachers (Id, Name, Email, PhoneNumber)
VALUES 
    ('T001', 'DrAlexander Harris', 'alexander.harris@school.edu', '555-1101'),
    ('T002', 'ProfIsabellaMartinez', 'isabella.martinez@school.edu', '555-1102'),
    ('T003', 'MrJamesWilson', 'james.wilson@school.edu', '555-1103'),
    ('T004', 'DrSophiaAnderson', 'sophia.anderson@school.edu', '555-1104'),
    ('T005', 'MsBenjaminThomas', 'benjamin.thomas@school.edu', NULL),
    ('T006', 'ProfOliviaJackson', 'olivia.jackson@school.edu', '555-1106'),
    ('T007', 'DrWilliamWhite', 'william.white@school.edu', '555-1107'),
    ('T008', 'MrsCharlotteLee', 'charlotte.lee@school.edu', '555-1108'),
    ('T009', 'MrDanielClark', 'daniel.clark@school.edu', NULL),
    ('T010', 'ProfAmeliaLewis', 'amelia.lewis@school.edu', '555-1110');

-- 2. Students
INSERT INTO Students (Id, Name, DateOfBirth, Email, PhoneNumber)
VALUES 
    ('S001', 'EmmaJohnson', '2006-03-15', 'emma.j@student.com', '555-2001'),
    ('S002', 'LiamSmith', '2005-07-22', 'liam.s@student.com', '555-2002'),
    ('S003', 'NoahWilliams', '2007-01-10', 'noah.w@student.com', NULL),
    ('S004', 'OliviaBrown', '2006-09-05', 'olivia.b@student.com', '555-2004'),
    ('S005', 'EthanJones', '2005-11-30', 'ethan.j@student.com', '555-2005'),
    ('S006', 'AvaGarcia', '2007-04-18', 'ava.g@student.com', '555-2006'),
    ('S007', 'SophiaMiller', '2006-06-25', 'sophia.m@student.com', NULL),
    ('S008', 'MasonDavis', '2005-12-12', 'mason.d@student.com', '555-2008'),
    ('S009', 'IsabellaRodriguez', '2007-08-08', 'isabella.r@student.com', '555-2009'),
    ('S010', 'LucasMartinez', '2006-10-20', 'lucas.m@student.com', '555-2010');


INSERT INTO Courses (Id, Name, TeacherId)
VALUES 
    ('MATH301', 'CalculusIII', 'T001'),
    ('PHYS201', 'PhysicsII', 'T003'),
    ('CS101', 'IntroductiontoProgramming', 'T004'),
    ('CHEM202', 'OrganicChemistry', 'T006'),
    ('HIST101', 'WorldHistory', 'T008');

INSERT INTO CourseStudents (CourseId, StudentId)
VALUES 
    ('MATH301', 'S001'), ('MATH301', 'S002'), ('MATH301', 'S003'), ('MATH301', 'S005'), ('MATH301', 'S008'),
    ('PHYS201', 'S002'), ('PHYS201', 'S004'), ('PHYS201', 'S006'), ('PHYS201', 'S007'), ('PHYS201', 'S009'),
    ('CS101', 'S001'), ('CS101', 'S003'), ('CS101', 'S005'), ('CS101', 'S006'), ('CS101', 'S010'),
    ('CHEM202', 'S004'), ('CHEM202', 'S005'), ('CHEM202', 'S007'), ('CHEM202', 'S008'), ('CHEM202', 'S010'),
    ('HIST101', 'S001'), ('HIST101', 'S004'), ('HIST101', 'S006'), ('HIST101', 'S009'), ('HIST101', 'S010');