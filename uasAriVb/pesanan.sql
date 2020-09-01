-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Feb 2019 pada 07.37
-- Versi server: 10.1.31-MariaDB
-- Versi PHP: 5.6.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pesanan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `kirim`
--

CREATE TABLE `kirim` (
  `id` int(3) NOT NULL,
  `jenis` varchar(20) NOT NULL,
  `pulau` varchar(10) NOT NULL,
  `berat` int(3) NOT NULL,
  `total` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kirim`
--

INSERT INTO `kirim` (`id`, `jenis`, `pulau`, `berat`, `total`) VALUES
(1, 'Kilat & P. Belah', 'Sumatera', 5, 5500),
(2, 'Kilat', 'Sumatera', 5, 110000),
(3, 'Cairan/P.Belah', 'Sumatera', 5, 105000),
(4, 'Cairan/P.Belah', 'Sumatera', 5, 105000),
(5, 'Cairan/P.Belah', 'Sumatera', 5, 105000),
(6, 'Cairan/P.Belah', 'Sumatera', 5, 105000),
(7, 'Tidak', 'Sumatera', 3, 60000),
(8, 'Kilat', 'Sumatera', 3, 66000),
(9, 'Tidak', 'Jawa', 3, 45000),
(10, 'Kilat & P. Belah', 'Sumatera', 3, 71500),
(11, 'Kilat', 'Sumatera', 5, 110000),
(12, 'Kilat', 'Sumatera', 5, 110000),
(13, 'Kilat & P. Belah', 'Sumatera', 5, 115500),
(14, 'Kilat & P. Belah', 'Sumatera', 5, 115500),
(15, 'Cairan/P.Belah', 'Sumatera', 5, 105000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `kirim`
--
ALTER TABLE `kirim`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `kirim`
--
ALTER TABLE `kirim`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
