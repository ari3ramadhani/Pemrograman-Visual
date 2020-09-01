-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Jan 2019 pada 15.08
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
-- Database: `mahasiswa`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `id` int(3) NOT NULL,
  `id_barang` int(5) NOT NULL,
  `nama_barang` varchar(10) NOT NULL,
  `stok` int(3) NOT NULL,
  `harga` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`id`, `id_barang`, `nama_barang`, `stok`, `harga`) VALUES
(1, 11, 'buku', 40, 30000),
(2, 12, 'komik', 30, 40000),
(3, 13, 'novel', 30, 50000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ha`
--

CREATE TABLE `ha` (
  `id` int(3) NOT NULL,
  `satu` int(10) NOT NULL,
  `dua` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ha`
--

INSERT INTO `ha` (`id`, `satu`, `dua`) VALUES
(1, 2016230037, 11),
(2, 2016230037, 11),
(3, 2016230037, 11),
(4, 2016230037, 11),
(5, 2016230036, 11);

-- --------------------------------------------------------

--
-- Struktur dari tabel `login`
--

CREATE TABLE `login` (
  `id` int(3) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `login`
--

INSERT INTO `login` (`id`, `username`, `password`, `level`) VALUES
(1, 'ari', '123', 'admin'),
(2, 'gilang', 'gilang', 'user');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mhs`
--

CREATE TABLE `mhs` (
  `id` int(8) NOT NULL,
  `nim` int(8) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `fakultas` varchar(50) NOT NULL,
  `jurusan` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `tanggal_masuk` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mhs`
--

INSERT INTO `mhs` (`id`, `nim`, `nama`, `fakultas`, `jurusan`, `status`, `tanggal_masuk`) VALUES
(1, 2016230001, 'najib', 'teknik', 'informatika', 'aktif', '2018-11-22'),
(2, 2016230022, 'fikri', 'teknik', 'informatika', 'aktif', '2018-11-14'),
(3, 2016230037, 'ari', 'teknik', 'informatika', 'aktif', '2018-11-14'),
(4, 2016230036, 'ikhsan', 'teknik', 'informatika', 'aktif', '2018-11-14'),
(5, 2016230034, 'lepoy', 'teknik', 'informatika', 'aktif', '2018-11-15'),
(9, 21312, 'saya', 'uweu', 'sayu', 'sayu', '2018-12-19');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pinjam`
--

CREATE TABLE `pinjam` (
  `id` int(5) NOT NULL,
  `lama_pinjam` int(3) NOT NULL,
  `tanggal_pinjam` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pinjam`
--

INSERT INTO `pinjam` (`id`, `lama_pinjam`, `tanggal_pinjam`) VALUES
(1, 2, '2018-12-14 00:00:00'),
(2, 3, '2018-12-11 00:00:00'),
(3, 4, '2018-12-06 00:00:00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(3) NOT NULL,
  `id_transaksi` varchar(20) NOT NULL,
  `nim` int(10) NOT NULL,
  `id_barang` int(4) NOT NULL,
  `jml_barang` int(3) NOT NULL,
  `tgl_transaksi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id`, `id_transaksi`, `nim`, `id_barang`, `jml_barang`, `tgl_transaksi`) VALUES
(7, '2016230037', 20181224, 11, 5, '2018-12-24 00:00:00'),
(8, '2016230037', 20181224, 11, 9, '2018-12-24 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `ha`
--
ALTER TABLE `ha`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `mhs`
--
ALTER TABLE `mhs`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `pinjam`
--
ALTER TABLE `pinjam`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `barang`
--
ALTER TABLE `barang`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `ha`
--
ALTER TABLE `ha`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `login`
--
ALTER TABLE `login`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `mhs`
--
ALTER TABLE `mhs`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `pinjam`
--
ALTER TABLE `pinjam`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
