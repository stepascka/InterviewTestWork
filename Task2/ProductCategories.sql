CREATE TABLE Products (
	id INT PRIMARY KEY,
	name TEXT
);

INSERT INTO Products
VALUES
	(1, 'Product1')
	,(2, 'Product2')
	,(3, 'Product3')
	,(4, 'Product4')
	,(5, 'Product5');

--
CREATE TABLE Categories (
	id INT PRIMARY KEY,
	name TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Category1')
	,(2, 'Category2')
	,(3, 'Category3');

--
CREATE TABLE ProductCategories (
	product_id INT FOREIGN KEY REFERENCES Products(id),
	category_id INT FOREIGN KEY REFERENCES Categories(id),
	PRIMARY KEY (product_id, category_id)
);

INSERT INTO ProductCategories
VALUES 
	(1, 2)
	,(1, 3)
	,(2, 2)
	,(3, 3)
	,(3, 2)
	,(4, 3);

--query
SELECT 
	p.name as ProductName
	,c.name as CategoryName
FROM 
	Products p
LEFT JOIN ProductCategories pc 
	ON p.id = pc.product_id
LEFT JOIN Categories c 
	ON pc.category_id = c.id;