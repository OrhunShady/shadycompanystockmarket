-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 28 Nis 2024, 10:35:46
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `stockmarketc`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `username` varchar(20) NOT NULL,
  `password` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('Orhun', 1234);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `products`
--

CREATE TABLE `products` (
  `Name` varchar(40) NOT NULL,
  `UnitNumber` int(40) NOT NULL,
  `Date` varchar(40) NOT NULL DEFAULT 'current_timestamp(6)',
  `Price` int(40) NOT NULL,
  `Quantıty` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `products`
--

INSERT INTO `products` (`Name`, `UnitNumber`, `Date`, `Price`, `Quantıty`) VALUES
('Macbook', 1, '2023-08-22 ', 1520, 23),
('Apple Watch', 2, '2023-08-22', 250, 15),
('Mouse', 3, '2024-03-25', 100, 500),
('Iphone', 4, '2024-02-21', 900, 200);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
