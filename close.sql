-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 18, 2017 at 04:05 AM
-- Server version: 5.7.15-log
-- PHP Version: 5.6.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `close`
--

-- --------------------------------------------------------

--
-- Table structure for table `lic`
--

CREATE TABLE `lic` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` text NOT NULL,
  `serial` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `lic`
--

INSERT INTO `lic` (`id`, `username`, `password`, `email`, `serial`) VALUES
(1, 'sadik', 'sadik', 'sadik@gmail.com', '2323423424234');

-- --------------------------------------------------------

--
-- Table structure for table `post`
--

CREATE TABLE `post` (
  `id` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `text` varchar(250) NOT NULL,
  `date` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `post`
--

INSERT INTO `post` (`id`, `name`, `text`, `date`) VALUES
(1, 'sadik', 'sdfsdsd', '09/03/2017 22:05:37'),
(2, 'sadik', 'sdsd', '09/03/2017 22:53:54'),
(3, 'sadik', 'marhaba [b] sadik abd elfattah [/b]', '10/03/2017 15:26:05'),
(4, '', 'sdsd', '10/03/2017 19:57:01'),
(5, 'sadik@gmail.com', 'salam [i]hhhhhh[/i]', '13/03/2017 21:44:52'),
(6, 'sadik@gmail.com', 'sadik [b]abd[/b] [i] sallam [/i]', '17/03/2017 11:12:36');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lic`
--
ALTER TABLE `lic`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `post`
--
ALTER TABLE `post`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `lic`
--
ALTER TABLE `lic`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `post`
--
ALTER TABLE `post`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
