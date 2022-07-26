create database event_managment;

use  event_managment;

CREATE TABLE CUSTOMER (
  customer_id varchar (10) NOT NULL,
  customer_fname varchar(25) NOT NULL,
  customer_lname varchar(25) NOT NULL,
  customer_contact varchar(20) NOT NULL,
  customer_housenumber varchar(10),
  customer_area varchar(15),
  customer_city varchar(15)  NOT NULL, 
  CONSTRAINT customer_pk PRIMARY KEY(customer_id)
)

INSERT INTO CUSTOMER (customer_id,customer_fname,customer_lname,customer_contact,customer_housenumber, customer_area, customer_city)
VALUES ('C-001','Omar','Sarfraz','03434985877','126-B','CANTT','OKARA'),
		('C-002','Wasiq','Rai','030688525579','p-46','BAGHBANPURA','FAISLABAD'),
		('C-003','Ammar','Amir','03023456789','19-A','LDA','SIALKOT'),
		('C-004','Farheen','Batool','03056752453','23-B','GHAUS  PARK','MANDI BAHAUDIN'),
		('C-005','Minal','Nazir','03126538900','A-112','GULBERG','LAHORE'),
		('C-006','Hammad','Hamid','03346587987','HR-234','LAKE CITY','OKARA'),
		('C-007','Bilal','Ahmad','03031287654','111-C','MODEL TOWN','LAHORE'),
		('C-008','Ali','Raza','03095672348','45-C','ALI PARK','JEHLUM'),
		('C-009','Amna','Akram','03036543212','12-A','DEFENCE ','LAHORE'),
		('C-010','Aisha','Allah yar','03048919273','1-AB','BAGHBANPURA','LAHORE');

CREATE TABLE EVENTT (
  event_id varchar (10) NOT NULL ,
  customer_id varchar (10) NOT NULL,
  event_name varchar(50) NOT NULL,
  event_type varchar(25) NOT NULL,
  event_expense int NOT NULL,
  event_price_decided int NOT NULL,
  event_advance int ,
  event_date date NOT NULL,
  event_start_time time NOT NULL,
  event_end_time time NOT NULL,
  event_venue varchar(50) NOT NULL,
  venue_city varchar(25) NOT NULL,
  CONSTRAINT event_pk PRIMARY KEY(event_id),
  CONSTRAINT fk_customerInevent FOREIGN KEY(customer_id) REFERENCES CUSTOMER(customer_id)
)



INSERT INTO EVENTT (event_id,customer_id,event_name,event_type,event_expense,event_price_decided,event_advance,event_date,event_start_time,event_end_time,event_venue,venue_city) VALUES
('EV-001','C-004','BIRTHDAY','INDOOR-HOTEL',15000,20000,6000,'2022-12-01','12:35:00','15:30:00','ROYAL PALACE','JARANWALA'),
('EV-002','C-006','MEHNDI','OUTDOOR',85000,100000,30000,'2022-11-04','13:35:00','15:30:00','CRICKET GROUND','GUJRANWALA'),
('EV-003','C-002','BIRTHDAY','INDOOR-HOME',32000,45000,12000,'2022-12-11','18:00:00','15:30:00','BAHRIA','LAHORE'),
('EV-004','C-003','BIRTHDAY','INDOOR-HOTEL',19000,27000,9000,'2022-10-21','12:35:00','15:30:00','ROYAL PALM','LAHORE'),
('EV-005','C-010','WEDDING','INDOOR-HOTEL',89000,110000,33000,'2022-09-21','16:00:00','15:30:00','PEARL CONTINENTAL','LAHORE'),
('EV-006','C-004','CONFERNCE','INDOOR-HOTEL',50000,650000,15000,'2022-11-14','14:15:00','15:30:00','FLATTIES','LAHORE'),
('EV-007','C-001','BIRTHDAY','INDOOR-HOME',30000,50000,10000,'2022-12-05','12:00:00','15:30:00','DHA','LAHORE'),
('EV-008','C-001','WALIMA','OUTDOOR',155000,190000,30000,'2022-12-09','13:35:00','10:30:00','ALI TOWN','OKARA'),
('EV-009','C-003','MEHNDI','OUTDOOR',75000,90000,30000,'2022-12-12','13:35:00','20:30:00','MODEL TOWN PARK','LAHORE'),
('EV-010','C-007','WEDDING','INDOOR-HOTEL',85000,100000,30000,'2022-11-15','13:35:00','15:30:00','ROYAL PALM','FAISALABAD');

CREATE TABLE EMPLOYEE (
  employee_id int NOT NULL,
  employee_type varchar(25)  NOT NULL,
  employee_fname varchar(25)  NOT NULL,
  employee_lname varchar(25)  NOT NULL,
  employee_cnic char(11)  NOT NULL,
  employee_father_cnic char(11)  NOT NULL,
  employee_contact1 varchar(20)  NOT NULL,
  employee_contact2 varchar(20),
  employee_date_of_birth date  NOT NULL,
  employee_joining_date date DEFAULT GETDATE(),
  employee_wage int  NOT NULL,
  employee_housenumber varchar(10),
  employee_area varchar(15),
  employee_city varchar(15)  NOT NULL, 
 )
 alter table employee alter column employee_id varchar(10) NOT NULL;
 alter table employee alter column employee_cnic char(15) NOT NULL;
 alter table employee alter column employee_father_cnic char(15) NOT NULL;
ALTER TABLE EMPLOYEE ADD CONSTRAINT employee_pk PRIMARY KEY(employee_id);


 INSERT INTO EMPLOYEE (employee_id, employee_type, employee_fname, employee_lname, employee_cnic,employee_father_cnic,
 employee_contact1, employee_contact2, employee_date_of_birth, employee_joining_date
 ,employee_wage,employee_housenumber,employee_area,employee_city) VALUES
 ('E-001','Helper','Ali','Ahmed','34232-1267982-7','34232-1237982-7','0332-4567899','0332-455329','1995-02-05','2020-11-01',20000,'45-A','LDA','LAHORE'),
  ('E-002','Decorator','Ahmad','Raza','34232-6729627-9','34232-6723427-9','0341-9876542','0341-9876123','1998-12-01','2020-12-09',30000,'12-A','DHA','LAHORE'),
   ('E-003','Helper','Akram','Faisal','34103-8362894-7','34103-8362123-7','0342-9898234','0342-9898456','1997-02-15','2021-04-14',20000,'78-b','ALI TOWN','RAIWIND'),
    ('E-004','Cashier','Shahzaib','Akram','32103-8232894-7','32103-1234564-7','0306-7898876','0312-7898876','1999-06-03','2021-07-11',350000,'19-A','HAJVERI TOWN','SHAHDRA'),
	 ('E-005','Helper','Ali','Nisar','33133-8362654-1','33133-9872654-1','0312-3676543','0312-3612677','1995-02-07','2021-11-11',20000,'4-p','VALENCIA','LAHORE'),
	  ('E-006','Decorator','Waqas','Gondal','34101-1232894-9','34101-6787128-9','0300-3345665','0310-3348723','1995-11-09','2022-01-18',30000,'P-46','CANTT','OKARA'),
	   ('E-007','Helper','Manan','Jutt','31103-1232823-7','31103-1546463-7','0301-8667876','0321-1237876','2000-04-15','2022-01-21',20000,'19A','LDA','LAHORE'),
	    ('E-008','Dealer','Qaiser','Batool','34111-1263894-3','34111-1245678-3','0306-8898982','0316-8899962','1995-02-23','2022-04-21',50000,'112-CA','LDA','LAHORE'),
		 ('E-009','Decorator','Qasim','Ali','33104-7067182-1','33104-7123452-1','0306-8855671','0326-1345671','1999-12-21','2022-07-19',30000,'98-X','BAGHBANPURA','LAHORE'),
		  ('E-010','Helper','Huzaifa','Asghar','33104-2342342-7','33104-2122342-7','0304-1298812','0314-1298976','1992-07-20','2022-11-15',20000,'12-M','LDA','LAHORE');
CREATE TABLE SUPPLIER(
  supplier_id varchar (10),
  supplier_fname varchar(25),
  supplier_lname varchar(25),
  shop_name varchar(25) NOT NULL,
  supplier_contact varchar(20),
  street_no varchar(25),
  supplier_number VARCHAR(30),
  supplier_area varchar(15) NOT NULL,
  supplier_city varchar(15) NOT NULL,
  CONSTRAINT supplier_pk PRIMARY KEY(supplier_id)
)
ALTER TABLE SUPPLIER DROP COLUMN SUPPLIER_CONTACT;
INSERT INTO SUPPLIER (supplier_id,supplier_fname,supplier_lname,shop_name,supplier_number,street_no,supplier_area,supplier_city) VALUES
		('S-001','Waqar','Mehmood','Decor Traders','03434985877','126-B','CANTT','OKARA'),
		('S-002','Zaid','Ali','Z n M ','030688525579','p-46','BAGHBANPURA','FAISLABAD'),
		('S-003','Hashir','Amir','Hashy Store','03023456789','19-A','LDA','SIALKOT'),
		('S-004','Hammad','Baqar','Mughal Brands','03056752453','23-B','GHAUS  PARK','MANDI BAHAUDIN'),
		('S-005','Asfand','Jatt','Echo Styles','03126538900','A-112','GULBERG','LAHORE'),
		('S-006','Hammad','Hamid','Decoration place','03346587987','HR-234','LAKE CITY','OKARA'),
		('S-007','Bilal','Hashmi','First Choice','03031287654','111-C','MODEL TOWN','LAHORE'),
		('S-008','Ali','Raza','Beauty Looks','03095672348','45-C','ALI PARK','JEHLUM'),
		('S-009','Faisal','Akram','All In One Shop','03036543212','12-A','DEFENCE ','LAHORE'),
		('S-010','Mansoor','Abdulllah','Hashim Traders','03048919273','1-AB','BAGHBANPURA','LAHORE');

CREATE TABLE AVAILABLE_ITEM_LIST (
	item_id varchar(10) NOT NULL,
  item_name varchar(20) NOT NULL,
  unit_price  int NOT NULL,
  CONSTRAINT item_list_pk PRIMARY KEY(ITEM_ID),
 
)


INSERT INTO AVAILABLE_ITEM_LIST (item_id,ITEM_NAME ,unit_price) VALUES 
('IT-001','Curtans',2000),
('IT-002','Reels',100),
('IT-003','Stands',2000),
('IT-004','Stage',20000),
('IT-005','Lamps',4500),
('IT-006','Vacuum',6000),
('IT-007','Showers',1500),
('IT-008','Crackers',100),
('IT-009','Floor',30000),
('IT-010','Sofa',20000),
('IT-011','Bulbs',200),
('IT-012','Chairs',600),
('IT-013','Stools',300),
('IT-014','Stairs',1000),
('IT-015','Disco Lights',2000),
('IT-016','Woofers',15000),
('IT-017','Sound System',150000),
('IT-018','Chandlers',30000),
('IT-019','Flowers',20),
('IT-020','Tents',5500);


CREATE TABLE STOCK_ITEM(
  stock_item_id varchar (10) NOT NULL,
  stock_item_quantity int NOT NULL,
  stock_item_description VARCHAR(100),
  CONSTRAINT Stock_item_pk PRIMARY KEY(stock_item_id),
  CONSTRAINT STOCK_ITEM_FK FOREIGN KEY(STOCK_ITEM_ID) REFERENCES AVAILABLE_ITEM_LIST(ITEM_ID)
)

INSERT INTO STOCK_ITEM (stock_item_id,  stock_item_quantity, stock_item_description)
VALUES ('It-019',25000,'Need White flowers'),
	('It-001',25,'New velvet'),
	('It-010',34,'Sofas For VIPs'),
	('It-020',6,'Yellow Cone Tents'),
	('It-004',3,'Moveable'),
	('It-009',2,'Dance Floor'),
	('It-012',400,'Height AdjuItable'),
	('It-011',50,'Energy Savers '),
	('It-018',6,'Heavily Powered 1000 Watt'),
	('It-016',9,'Wireless');

CREATE TABLE SUPPLIED_ITEM_RECEIPT(
   item_id varchar (10) NOT NULL,
   supplier_id varchar (10),
   supplied_item_quantity int NOT NULL,
   given_amount int NOT NULL,
   supplied_date date DEFAULT GETDATE(),
   CONSTRAINT supplied_item_pk PRIMARY KEY(supplier_id,item_id,supplied_date), 
   CONSTRAINT fk_itemSupplier FOREIGN KEY(supplier_id) REFERENCES  SUPPLIER(supplier_id),
   CONSTRAINT fk_item FOREIGN KEY(item_id) REFERENCES  STOCK_ITEM(stock_item_id)
)

ALTER TABLE SUPPLIED_ITEM_RECEIPT ADD TOTAL_AMOUNT INT ;
ALTER TABLE SUPPLIED_ITEM_RECEIPT ADD CONSTRAINT pk_sup PRIMARY KEY (supplier_id,itemi_id,supplied_date)


INSERT INTO SUPPLIED_ITEM_RECEIPT (item_id,supplier_id,supplied_item_quantity,given_amount,supplied_date)
VALUES ('It-019','S-002',2500 ,1000 ,'2022-04-12'),
('It-001','S-002' ,10,5000 ,'2022-04-11'),
('It-019','S-006',2000 ,3000 ,'2022-04-21'),
('It-012','S-001',250 ,5000 ,'2022-03-01'),
('It-011','S-008',25 ,2000 ,'2022-04-29'),
('It-020','S-004',2 ,8000 ,'2022-04-14'),
('It-009','S-009',1 ,5000 ,'2022-02-15'),
('It-016','S-010',2 ,5000 ,'2022-06-09'),
('It-004','S-001',1 ,6000 ,'2022-08-12'),
('It-018','S-003',1 ,5000 ,'2022-01-16'),
('It-019','S-007',2500 ,2000 ,'2022-09-03');

INSERT INTO SUPPLIED_ITEM_RECEIPT (TOTAL_PRICE) VALUES (SELECT (SUPPLIED_ITEM_RECEIPT.supplied_item_quantity*AVAILABLE_ITEM_LIST.UNIT_PRICE) AS TOTAL_PRICE FROM AVAILABLE_ITEM_LIST JOIN SUPPLIED_ITEM_RECEIPT ON SUPPLIED_ITEM_RECEIPT.item_id = AVAILABLE_ITEM_LIST.item_id);

CREATE VIEW supplied_item_view AS
SELECT SUPPLIED_ITEM_RECEIPT.item_id,AVAILABLE_ITEM_LIST.item_name, SUPPLIED_ITEM_RECEIPT.supplier_id,SUPPLIER.supplier_fname + ' ' + SUPPLIER.supplier_lname AS SupplierName ,SUPPLIED_ITEM_RECEIPT.supplied_item_quantity,AVAILABLE_ITEM_LIST.unit_price
,SUPPLIED_ITEM_RECEIPT.TOTAL_AMOUNT, SUPPLIED_ITEM_RECEIPT.given_amount,((SUPPLIED_ITEM_RECEIPT.SUPPLIED_ITEM_QUANTITY*AVAILABLE_ITEM_LIST.UNIT_PRICE)-given_amount)AS TO_PAY_AMOUNT
,SUPPLIED_ITEM_RECEIPT.supplied_date FROM SUPPLIED_ITEM_RECEIPT 
JOIN SUPPLIER ON SUPPLIER.supplier_id = SUPPLIED_ITEM_RECEIPT.supplier_id
JOIN 
AVAILABLE_ITEM_LIST ON SUPPLIED_ITEM_RECEIPT.item_id=AVAILABLE_ITEM_LIST.item_id;

select * from supplied_item_view

CREATE TABLE ITEM_USED (
  event_id varchar (10) NOT NULL,
  stock_item_id varchar (10) NOT NULL,
  used_quantity int NOT NULL,
  CONSTRAINT item_used_pk PRIMARY KEY(event_id,stock_item_id),
  CONSTRAINT fk_eventInItemUsed FOREIGN KEY(event_id) REFERENCES EVENTT(event_id),
  CONSTRAINT fk_Stockitemused FOREIGN KEY(stock_item_id) REFERENCES AVAILABLE_ITEM_LIST(item_id)
)


INSERT INTO ITEM_USED (event_id,stock_item_id,used_quantity) VALUES
('EV-001','IT-001',20),
('EV-001','IT-004',2),
('EV-002','IT-0011',200),
('EV-006','IT-001',10),
('EV-005','IT-019',2000),
('EV-001','IT-012',200),
('EV-007','IT-019',1),
('EV-008','IT-011',20),
('EV-001','IT-018',8),
('EV-003','IT-001',20);

CREATE TABLE WORK_DETAILS(
 event_id varchar (10),
 employee_id varchar (10),
 assigned_work varchar(50),
 work_date date DEFAULT GETDATE(),
 employee_arrived time ,
 employee_left time ,
 employee_remarks  varchar (255),
 damage_by_employee varchar(255),

 CONSTRAINT fk_eventInwork FOREIGN KEY(event_id) REFERENCES EVENTT(event_id), 
 
 CONSTRAINT work_pk PRIMARY KEY(event_id,employee_id)
)
ALTER TABLE WORK_DETAILS ADD CONSTRAINT fk_employeeInwork FOREIGN KEY(employee_id) REFERENCES EMPLOYEE(employee_id);
ALTER TABLE WORK_DETAILS ALTER COLUMN EMPLOYEE_ID VARCHAR(10) NOT NULL;

INSERT INTO WORK_DETAILS(event_id,employee_id,assigned_work,employee_arrived,employee_left,employee_remarks,damage_by_employee) VALUES ('EV-001','E-001','HELPER','14:14','16:20','GOOD','NO'),
								('EV-001','E-002','DECORATION','12:24','16:20','GOOD','NO'),
								('EV-001','E-003','HELPER','11:04','16:20','GOOD','2 CHAIRS'),
								('EV-001','E-008','DEALER','01:12','16:20','GOOD','NO'),
								('EV-002','E-005','HELPER','04:10','16:20','GOOD','NO'),
								('EV-002','E-007','HELPER','14:14','16:20','GOOD','1 CHANDLER'),
								('EV-002','E-009','DECORATOR','09:10','16:20','GOOD','NO'),
								('EV-002','E-008','DEALER','10:10','16:20','GOOD','NO'),
								('EV-003','E-008','DEALER','15:24','16:20','GOOD','NO'),
								('EV-003','E-004','CASHIER','13:30','16:20','GOOD','NO');

create view stock_items_view As
SELECT stock_item_id,ITEM_NAME,stock_item_quantity,stock_item_description FROM STOCK_ITEM JOIN AVAILABLE_ITEM_LIST ON STOCK_ITEM.stock_item_id = AVAILABLE_ITEM_LIST.ITEM_ID


create view work_details_of_an_employee AS
SELECT work_details.event_id,event_name,work_details.employee_id,EMPLOYEE.employee_fname + ' ' + EMPLOYEE.employee_lname AS employee_name,assigned_work,employee_arrived,employee_left,employee_remarks,damage_by_employee FROM work_details JOIN EVENTT ON WORK_DETAILS.event_id = EVENTT.event_id JOIN Employee ON WORK_DETAILS.employee_id = Employee.employee_id;

SELECT (SUM(EVENTT.event_price_decided) - SUM(EVENTT.event_expense)) FROM EVENTT WHERE EVENTT.event_date BETWEEN '2022-11-01' AND '2022-11-30';


create procedure EventsPresent @from date , @till date
as
SELECT Event_Name AS Eventss, event_date AS dates
FROM Eventt 
WHERE  event_date > @from  AND event_date <  @till 
ORDER BY event_date;
go

create procedure CustomersPresent @from date , @till date
as
SELECT customer_fName+' ' +customer_lName AS Names, EVENTT.event_date As Dates
FROM CUSTOMER ,Eventt where Customer.customer_id= Eventt.customer_id AND
event_date > @from  AND event_date <  @till 
ORDER BY event_date;
go
drop procedure EventsPresent