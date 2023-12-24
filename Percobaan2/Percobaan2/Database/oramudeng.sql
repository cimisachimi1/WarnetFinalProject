-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 23 Des 2023 pada 17.54
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bilingwarnet`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akunpelanggan`
--

CREATE TABLE `akunpelanggan` (
  `Username` varchar(50) NOT NULL,
  `ID_Pelanggan` int(20) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `akunpelanggan`
--

INSERT INTO `akunpelanggan` (`Username`, `ID_Pelanggan`, `Password`) VALUES
('adamskuy', 1001, 'theadams'),
('adzriel', 1002, 'zzziel'),
('arsya', 1003, 'acamoo'),
('dinda', 1004, 'bumbuma'),
('ikaa', 1005, 'mikasaa'),
('topikk', 1006, 'thisiscogil'),
('faturijat', 1007, 'auauo'),
('ffera', 1008, 'saafer'),
('deden', 1009, 'alexs'),
('sheva', 1010, 'asep'),
('gheaa', 1011, 'itsme');

-- --------------------------------------------------------

--
-- Struktur dari tabel `komputerwarnet`
--

CREATE TABLE `komputerwarnet` (
  `ID_Komputer` int(20) NOT NULL,
  `Ketersediaan` varchar(50) NOT NULL,
  `Jenis_Komputer` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `komputerwarnet`
--

INSERT INTO `komputerwarnet` (`ID_Komputer`, `Ketersediaan`, `Jenis_Komputer`) VALUES
(121, 'YA', 'VIP'),
(132, 'YA', 'REGULER');

-- --------------------------------------------------------

--
-- Struktur dari tabel `layanantambahan`
--

CREATE TABLE `layanantambahan` (
  `ID_Layanan_Tambahan` int(20) NOT NULL,
  `ID_Pelanggan` int(20) NOT NULL,
  `Makanan` varchar(50) NOT NULL,
  `Minuman` varchar(50) NOT NULL,
  `Print` varchar(50) NOT NULL,
  `Total_Layanan` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `layanantambahan`
--

INSERT INTO `layanantambahan` (`ID_Layanan_Tambahan`, `ID_Pelanggan`, `Makanan`, `Minuman`, `Print`, `Total_Layanan`) VALUES
(6253, 1001, 'nasi goreng', 'es jeruk', '2 lembar', 25000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `operator`
--

CREATE TABLE `operator` (
  `ID_Operator` int(20) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Umur` int(3) NOT NULL,
  `Mulai_Shift` time DEFAULT NULL,
  `Akhir_Shift` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `operator`
--

INSERT INTO `operator` (`ID_Operator`, `Nama`, `Alamat`, `Umur`, `Mulai_Shift`, `Akhir_Shift`) VALUES
(5167, 'nadia', 'concat', 20, '15:00:00', '22:00:00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_Pelanggan` int(20) NOT NULL,
  `Nama_Pelanggan` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `NomerHP` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`ID_Pelanggan`, `Nama_Pelanggan`, `Alamat`, `Email`, `NomerHP`) VALUES
(1001, 'adam huzaini', 'maguwo', 'adamhuzaini@gmail.com', '085277363264'),
(1002, 'jamal', 'concat', 'jamal@gmail.com', '087786543214');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sesirental`
--

CREATE TABLE `sesirental` (
  `ID_SesiRental` int(20) NOT NULL,
  `WaktuMulai` datetime DEFAULT NULL,
  `WaktuSelesai` datetime DEFAULT NULL,
  `Durasi` datetime DEFAULT NULL,
  `Username` varchar(50) NOT NULL,
  `ID_Komputer` int(20) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Total_Rental` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `sesirental`
--

INSERT INTO `sesirental` (`ID_SesiRental`, `WaktuMulai`, `WaktuSelesai`, `Durasi`, `Username`, `ID_Komputer`, `Password`, `Total_Rental`) VALUES
(1234, '2023-12-23 23:38:15', '2023-12-23 22:38:15', '2023-12-17 01:00:00', 'adamskuy', 121, 'theadams', 1),
(2345, '2023-12-22 20:46:15', '2023-12-22 22:46:15', '2023-12-22 20:00:00', 'topikk', 132, 'thisiscogil', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_Transaksi` int(20) NOT NULL,
  `Tanggal_Transaksi` datetime DEFAULT NULL,
  `ID_SesiRental` int(20) NOT NULL,
  `ID_Layanan_Tambahan` int(20) NOT NULL,
  `ID_Operator` int(20) NOT NULL,
  `Total_Biaya` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`ID_Transaksi`, `Tanggal_Transaksi`, `ID_SesiRental`, `ID_Layanan_Tambahan`, `ID_Operator`, `Total_Biaya`) VALUES
(1111, '2023-12-23 23:53:18', 2345, 6253, 5167, 20000),
(1112, '2023-12-22 22:52:54', 1234, 6253, 5167, 12000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akunpelanggan`
--
ALTER TABLE `akunpelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indeks untuk tabel `komputerwarnet`
--
ALTER TABLE `komputerwarnet`
  ADD PRIMARY KEY (`ID_Komputer`);

--
-- Indeks untuk tabel `layanantambahan`
--
ALTER TABLE `layanantambahan`
  ADD PRIMARY KEY (`ID_Layanan_Tambahan`),
  ADD KEY `ID_Pelanggan` (`ID_Pelanggan`);

--
-- Indeks untuk tabel `operator`
--
ALTER TABLE `operator`
  ADD PRIMARY KEY (`ID_Operator`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indeks untuk tabel `sesirental`
--
ALTER TABLE `sesirental`
  ADD PRIMARY KEY (`ID_SesiRental`),
  ADD KEY `Username` (`Username`),
  ADD KEY `ID_Komputer` (`ID_Komputer`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_Transaksi`),
  ADD KEY `ID_SesiRental` (`ID_SesiRental`),
  ADD KEY `ID_Operator` (`ID_Operator`),
  ADD KEY `transaksi_ibfk_2` (`ID_Layanan_Tambahan`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `layanantambahan`
--
ALTER TABLE `layanantambahan`
  ADD CONSTRAINT `layanantambahan_ibfk_1` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `pelanggan` (`ID_Pelanggan`),
  ADD CONSTRAINT `layanantambahan_ibfk_2` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `akunpelanggan` (`ID_Pelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
