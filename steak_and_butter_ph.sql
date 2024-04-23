-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2022 at 01:16 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `steak_and_butter_ph`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `criticalalert`
-- (See below for the actual view)
--
CREATE TABLE `criticalalert` (
`Product Name` varchar(50)
,`Critical Level` int(64)
);

-- --------------------------------------------------------

--
-- Table structure for table `deposit_tbl`
--

CREATE TABLE `deposit_tbl` (
  `deposit_id` int(11) NOT NULL,
  `deposit_Date` varchar(10) DEFAULT NULL,
  `supplier_ID` int(11) NOT NULL,
  `company_name` varchar(50) DEFAULT NULL,
  `product_Name` varchar(50) DEFAULT NULL,
  `product_quantity` int(11) DEFAULT NULL,
  `supplier_contact` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `deposit_tbl`
--

INSERT INTO `deposit_tbl` (`deposit_id`, `deposit_Date`, `supplier_ID`, `company_name`, `product_Name`, `product_quantity`, `supplier_contact`) VALUES
(1, '12/12/2022', 1, 'MEAT CO.1', 'USDA Butter Aged Ribeye Steak', 400, 98766543219),
(2, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 100, 98766543219),
(3, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 1000, 98766543219),
(4, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 100, 98766543219),
(5, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 200, 98766543219);

-- --------------------------------------------------------

--
-- Table structure for table `employee_tb`
--

CREATE TABLE `employee_tb` (
  `Employee_ID` int(11) NOT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Address` varchar(75) NOT NULL,
  `EmailAddress` varchar(75) NOT NULL,
  `ContactNum` bigint(11) NOT NULL,
  `Privilege` varchar(25) NOT NULL,
  `user` varchar(30) NOT NULL,
  `pass` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_tb`
--

INSERT INTO `employee_tb` (`Employee_ID`, `FirstName`, `LastName`, `Address`, `EmailAddress`, `ContactNum`, `Privilege`, `user`, `pass`) VALUES
(4, 'Administrator', 'Administrator', 'Administrator', 'Administrator', 9876543219, 'Admin', 'Administrator', 'Admin12345'),
(5, 'Renz Earl', 'Arcibal', 'Sabahay Nila St.', 'renzearlarcibal@gmail.com', 9876543219, 'Employee', 'renzearl', 'Arcival');

-- --------------------------------------------------------

--
-- Stand-in structure for view `expirationalert`
-- (See below for the actual view)
--
CREATE TABLE `expirationalert` (
`Product Name` varchar(50)
,`Expiration Date` date
);

-- --------------------------------------------------------

--
-- Table structure for table `product_tbl`
--

CREATE TABLE `product_tbl` (
  `product_ID` int(11) NOT NULL,
  `product_name` varchar(50) DEFAULT NULL,
  `prod_quantity` int(11) DEFAULT NULL,
  `price` double(7,2) DEFAULT NULL,
  `supplier_ID` int(11) NOT NULL,
  `Best_Before` date DEFAULT NULL,
  `Expiration_Date` date DEFAULT NULL,
  `Critical_Level` int(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_tbl`
--

INSERT INTO `product_tbl` (`product_ID`, `product_name`, `prod_quantity`, `price`, `supplier_ID`, `Best_Before`, `Expiration_Date`, `Critical_Level`) VALUES
(1, 'USDA Butter Aged Ribeye Steak', 290, 1399.00, 1, '2023-07-19', '2023-12-22', 50),
(2, 'Japanese Wagyu Cubes', 300, 1499.00, 1, '2023-07-19', '2024-02-02', 50),
(3, 'Australian Butter-Aged T-Bone  Steak', 250, 949.00, 1, '2023-07-19', '2024-01-17', 50),
(4, 'USDA Angus Ribeye Steak Slab', 300, 1349.00, 1, '2023-07-19', '2023-09-11', 50),
(5, 'Cheesy/Spicy Hungarian Sausage', 290, 399.00, 1, '2023-07-19', '2024-05-26', 50),
(6, 'Compound Butter', 450, 160.00, 1, '2023-07-19', '2024-06-01', 50),
(7, 'Mixed Herbs', 535, 160.00, 1, '2023-07-19', '2024-06-17', 50),
(8, 'Gift Bundle', 300, 2199.00, 1, '2023-07-19', '2024-12-30', 50),
(19, 'New Product', 350, 499.00, 2, '2022-12-08', '2022-12-08', 20),
(20, 'New Product S', 1430, 599.00, 1, '2022-12-12', '2022-12-12', 50);

-- --------------------------------------------------------

--
-- Stand-in structure for view `stockalert`
-- (See below for the actual view)
--
CREATE TABLE `stockalert` (
`Product Name` varchar(50)
,`Quantity` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `supplier_tbl`
--

CREATE TABLE `supplier_tbl` (
  `supplier_ID` int(11) NOT NULL,
  `company_name` varchar(50) DEFAULT NULL,
  `address` varchar(80) DEFAULT NULL,
  `email` varchar(80) DEFAULT NULL,
  `contactNum` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier_tbl`
--

INSERT INTO `supplier_tbl` (`supplier_ID`, `company_name`, `address`, `email`, `contactNum`) VALUES
(1, 'MEAT CO.1', '11 Rocky St. Como 1234', 'meatco1@gmail.com', 98766543219),
(2, 'BUTTER CO.1', '12 Rocky St. Como 1234', 'butterco1@gmail.com', 98766543219),
(3, 'VEGGIE CO.1', '13 Rocky St. Como 1234', 'veggieco1@gmail.com', 98766543219),
(4, 'CONDIMENT CO.1', '13 Rocky St. Como 1234', 'condimentco1@gmail.com', 98766543219);

-- --------------------------------------------------------

--
-- Table structure for table `user_tb`
--

CREATE TABLE `user_tb` (
  `FirstName` varchar(255) DEFAULT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `User` varchar(255) DEFAULT NULL,
  `Pass` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_tb`
--

INSERT INTO `user_tb` (`FirstName`, `MiddleName`, `LastName`, `User`, `Pass`) VALUES
('BlackBird', 'Ibon', 'Asoy', 'Admin', 'Admin'),
('First', 'Middle', 'Last', 'Admin1', 'Admin1');

-- --------------------------------------------------------

--
-- Table structure for table `withdraw_tbl`
--

CREATE TABLE `withdraw_tbl` (
  `withdraw_ID` int(11) NOT NULL,
  `withdraw_Date` varchar(10) DEFAULT NULL,
  `supplier_ID` int(11) NOT NULL,
  `company_name` varchar(50) DEFAULT NULL,
  `product_Name` varchar(50) DEFAULT NULL,
  `product_quantity` int(11) DEFAULT NULL,
  `supplier_contact` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `withdraw_tbl`
--

INSERT INTO `withdraw_tbl` (`withdraw_ID`, `withdraw_Date`, `supplier_ID`, `company_name`, `product_Name`, `product_quantity`, `supplier_contact`) VALUES
(1, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 250, 98766543219),
(2, '12/12/2022', 1, 'MEAT CO.1', 'New Product S', 120, 98766543219);

-- --------------------------------------------------------

--
-- Structure for view `criticalalert`
--
DROP TABLE IF EXISTS `criticalalert`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `criticalalert`  AS SELECT `product_tbl`.`product_name` AS `Product Name`, `product_tbl`.`Critical_Level` AS `Critical Level` FROM `product_tbl``product_tbl`  ;

-- --------------------------------------------------------

--
-- Structure for view `expirationalert`
--
DROP TABLE IF EXISTS `expirationalert`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `expirationalert`  AS SELECT `product_tbl`.`product_name` AS `Product Name`, `product_tbl`.`Expiration_Date` AS `Expiration Date` FROM `product_tbl` ORDER BY `product_tbl`.`Expiration_Date` ASC  ;

-- --------------------------------------------------------

--
-- Structure for view `stockalert`
--
DROP TABLE IF EXISTS `stockalert`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `stockalert`  AS SELECT `product_tbl`.`product_name` AS `Product Name`, `product_tbl`.`prod_quantity` AS `Quantity` FROM `product_tbl` ORDER BY `product_tbl`.`prod_quantity` ASC  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `deposit_tbl`
--
ALTER TABLE `deposit_tbl`
  ADD PRIMARY KEY (`deposit_id`),
  ADD KEY `supplier_ID` (`supplier_ID`);

--
-- Indexes for table `employee_tb`
--
ALTER TABLE `employee_tb`
  ADD PRIMARY KEY (`Employee_ID`);

--
-- Indexes for table `product_tbl`
--
ALTER TABLE `product_tbl`
  ADD PRIMARY KEY (`product_ID`),
  ADD KEY `supplier_ID` (`supplier_ID`);

--
-- Indexes for table `supplier_tbl`
--
ALTER TABLE `supplier_tbl`
  ADD PRIMARY KEY (`supplier_ID`);

--
-- Indexes for table `withdraw_tbl`
--
ALTER TABLE `withdraw_tbl`
  ADD PRIMARY KEY (`withdraw_ID`),
  ADD KEY `supplier_ID` (`supplier_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `deposit_tbl`
--
ALTER TABLE `deposit_tbl`
  MODIFY `deposit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `employee_tb`
--
ALTER TABLE `employee_tb`
  MODIFY `Employee_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `product_tbl`
--
ALTER TABLE `product_tbl`
  MODIFY `product_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `supplier_tbl`
--
ALTER TABLE `supplier_tbl`
  MODIFY `supplier_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `withdraw_tbl`
--
ALTER TABLE `withdraw_tbl`
  MODIFY `withdraw_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deposit_tbl`
--
ALTER TABLE `deposit_tbl`
  ADD CONSTRAINT `deposit_tbl_ibfk_1` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier_tbl` (`supplier_ID`);

--
-- Constraints for table `product_tbl`
--
ALTER TABLE `product_tbl`
  ADD CONSTRAINT `product_tbl_ibfk_1` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier_tbl` (`supplier_ID`);

--
-- Constraints for table `withdraw_tbl`
--
ALTER TABLE `withdraw_tbl`
  ADD CONSTRAINT `withdraw_tbl_ibfk_1` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier_tbl` (`supplier_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
