-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 02, 2021 at 02:50 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekammedis`
--

-- --------------------------------------------------------

--
-- Table structure for table `lapresume`
--

CREATE TABLE `lapresume` (
  `No_RM` varchar(50) NOT NULL,
  `DPJP` varchar(50) NOT NULL,
  `Diagnosis` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbdokter`
--

CREATE TABLE `tbdokter` (
  `Kode_Dokter` varchar(50) NOT NULL,
  `Nama_Dokter` varchar(50) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Spesialis` varchar(50) NOT NULL,
  `Nomor_Telepon` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbdokter`
--

INSERT INTO `tbdokter` (`Kode_Dokter`, `Nama_Dokter`, `Tanggal_Lahir`, `Spesialis`, `Nomor_Telepon`, `Alamat`) VALUES
('DR0001', 'Dr.Dani', '1994-07-20', 'Spesialis Anak', '072329248294', 'Jln.Kenanga No.42, Bandung'),
('DR0002', 'Dr.Hadi', '1890-06-10', 'Spesialis Bedah', '082274624', 'Jln.Mawar No. 32, Bandung'),
('DR0003', 'Dr.Mira', '2000-01-02', 'Spesialis Umum', '0854822849294', 'Jln. Nusa, No.17, Bandung');

-- --------------------------------------------------------

--
-- Table structure for table `tbpasien`
--

CREATE TABLE `tbpasien` (
  `No_RM` varchar(50) NOT NULL,
  `No_KTP` varchar(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Jenis_Kelamin` varchar(50) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Umur` varchar(50) NOT NULL,
  `Poliklinik` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Pekerjaan` varchar(50) NOT NULL,
  `No_Telepon` varchar(50) NOT NULL,
  `Tanggal_Masuk` date NOT NULL,
  `Tanggal_Keluar` date NOT NULL,
  `Kode_Dokter` varchar(50) NOT NULL,
  `Nama_Dokter` varchar(50) NOT NULL,
  `Spesialis` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbpasien`
--

INSERT INTO `tbpasien` (`No_RM`, `No_KTP`, `Nama`, `Jenis_Kelamin`, `Tanggal_Lahir`, `Umur`, `Poliklinik`, `Alamat`, `Pekerjaan`, `No_Telepon`, `Tanggal_Masuk`, `Tanggal_Keluar`, `Kode_Dokter`, `Nama_Dokter`, `Spesialis`) VALUES
('140001', '328323209320202', 'Sopie Siti Sopiah', 'PEREMPUAN', '2000-08-14', '21', 'Poli Umum', 'Jln. Cicadas, No.32 Bandung', 'Mahasiswa', '089748248374', '2021-10-30', '2021-10-31', 'DR0003', 'Dr.Mira', 'Spesialis Umum'),
('140002', '322430430930535', 'Hana Fadillah', 'PEREMPUAN', '2000-02-03', '21', 'Poli Anak', 'Jln. SetiaBudi, No. 15, Bandung', 'Mahasiswa', '08826722246', '2021-10-30', '2021-10-31', 'DR0001', 'Dr.Dani', 'Spesialis Anak'),
('140003', '3293830599305', 'Alexander', 'LAKI-LAKI', '2000-07-14', '20', 'Poli Bedah', 'Jln. Sudirman, No.20, Bandung', 'Karyawan', '0852492494345', '2021-10-28', '2021-10-31', 'DR0002', 'Dr.Hadi', 'Spesialis Bedah');

-- --------------------------------------------------------

--
-- Table structure for table `tbperminresume`
--

CREATE TABLE `tbperminresume` (
  `Tanggal` date NOT NULL,
  `No_RM` varchar(225) NOT NULL,
  `Nama_Pasien` varchar(225) NOT NULL,
  `Alamat` varchar(225) NOT NULL,
  `Nomor_Telepon` varchar(225) NOT NULL,
  `Nama_Pemohon` varchar(225) NOT NULL,
  `Keperluan` varchar(225) NOT NULL,
  `Jenis_Kelamin_Pasien` varchar(50) NOT NULL,
  `Tanggal_Lahir_Pasien` date NOT NULL,
  `Poliklinik` varchar(50) NOT NULL,
  `Umur_Pasien` varchar(50) NOT NULL,
  `Tanggal_Masuk_Pasien` date NOT NULL,
  `Tanggal_Keluar_Pasien` date NOT NULL,
  `Kode_Dokter` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbperminresume`
--

INSERT INTO `tbperminresume` (`Tanggal`, `No_RM`, `Nama_Pasien`, `Alamat`, `Nomor_Telepon`, `Nama_Pemohon`, `Keperluan`, `Jenis_Kelamin_Pasien`, `Tanggal_Lahir_Pasien`, `Poliklinik`, `Umur_Pasien`, `Tanggal_Masuk_Pasien`, `Tanggal_Keluar_Pasien`, `Kode_Dokter`) VALUES
('2021-10-30', '140001', 'Sopie Siti Sopiah', 'Jln. Cicadas, No.32 Bandung', '089748248374', 'Sopie Siti Sopiah', 'Pengajuan Klaim Asuransi Bank BCA mulai pengobatan dari tahun 2018 s/d 2021', 'PEREMPUAN', '2000-08-14', 'Poli Umum', '21', '2021-10-30', '2021-10-31', 'DR0003'),
('2021-10-30', '140002', 'Hana Fadillah', 'Jln. SetiaBudi, No. 15, Bandung', '08826722246', 'Hana Fadillah', 'Cek Administrasi selama masa perawatan di tahun 2021', 'PEREMPUAN', '2000-02-03', 'Poli Anak', '21', '2021-10-30', '2021-10-31', 'DR0001'),
('2021-10-30', '140003', 'Alexander', 'Jln. Sudirman, No.20, Bandung', '0852492494345', 'Jessika Milla', 'Meminta riwayat sakit rahasia selama masa pengobatan dari tahun 2020 s/d 2021', 'LAKI-LAKI', '2000-07-14', 'Poli Bedah', '20', '2021-10-28', '2021-10-31', 'DR0002');

-- --------------------------------------------------------

--
-- Table structure for table `tbresumemedis`
--

CREATE TABLE `tbresumemedis` (
  `No_RM` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Umur` varchar(30) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `No_Peserta` varchar(50) NOT NULL,
  `Jenis_Kelamin` varchar(50) NOT NULL,
  `Anamnesis` varchar(50) NOT NULL,
  `T` varchar(20) NOT NULL,
  `N` varchar(20) NOT NULL,
  `D` varchar(20) NOT NULL,
  `P` varchar(20) NOT NULL,
  `Kelainan_yang_ditemukan` varchar(50) NOT NULL,
  `Diagnosa_Utama` varchar(50) NOT NULL,
  `Diagnosa_tambahan` varchar(50) NOT NULL,
  `Terapi` varchar(50) NOT NULL,
  `Tindakan` varchar(50) NOT NULL,
  `Catatan` varchar(50) NOT NULL,
  `Kode_Dokter` varchar(50) NOT NULL,
  `DPJP` varchar(50) NOT NULL,
  `Spesialis` varchar(50) NOT NULL,
  `Poliklinik` varchar(50) NOT NULL,
  `Tanggal` date NOT NULL,
  `Tanggal_Masuk` date NOT NULL,
  `Tanggal_Keluar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbresumemedis`
--

INSERT INTO `tbresumemedis` (`No_RM`, `Nama`, `Umur`, `Tanggal_Lahir`, `Alamat`, `No_Peserta`, `Jenis_Kelamin`, `Anamnesis`, `T`, `N`, `D`, `P`, `Kelainan_yang_ditemukan`, `Diagnosa_Utama`, `Diagnosa_tambahan`, `Terapi`, `Tindakan`, `Catatan`, `Kode_Dokter`, `DPJP`, `Spesialis`, `Poliklinik`, `Tanggal`, `Tanggal_Masuk`, `Tanggal_Keluar`) VALUES
('140001', 'Sopie Siti Sopiah', '21', '2000-08-14', 'Jln. Cicadas, No.32 Bandung', '001', 'PEREMPUAN', 'Tidak ditemukan', '50', '20', '60', '10', 'Tidak Ada', 'Demam Tinggi', 'Gejala Flu, Batuk', 'Cek darah, BB', 'Pemberian obat pereda demam serta Influenza', 'Istirahat', 'DR0003', 'Dr.Mira', 'Spesialis Umum', 'Poli Umum', '2021-10-30', '2021-10-30', '2021-10-31'),
('140002', 'Hana Fadillah', '21', '2000-02-03', 'Jln. SetiaBudi, No. 15, Bandung', '002', 'PEREMPUAN', 'Sesak Nafas', '25', '40', '20', '15', 'Tidak Ada', 'Asma ', 'Demam ringan', 'Cek BB, darah, dan saluran pernafasan', 'Pemberian obat asma dan O2 secara rutin ', 'Kontrol', 'DR0001', 'Dr.Dani', 'Spesialis Anak', 'Poli Anak', '2021-10-30', '2021-10-30', '2021-10-31'),
('140003', 'Alexander', '20', '2000-07-14', 'Jln. Sudirman, No.20, Bandung', '003', 'LAKI-LAKI', 'Tidak ada', '40', '20', '15', '10', 'Tidak ada', 'Batu Ginjal', 'Demam', 'Cek BB, darah, HB', 'Pemberian obat steril pereda luka dan NACL', 'Dirujuk', 'DR0002', 'Dr.Hadi', 'Spesialis Bedah', 'Poli Bedah', '2021-10-30', '2021-10-28', '2021-10-31');

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `Id_User` varchar(20) NOT NULL,
  `username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Jabatan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`Id_User`, `username`, `Password`, `Jabatan`) VALUES
('RM0001', 'sopie', 'sayang', 'Rekam Medis'),
('HNA123', 'hanaf55', 'hana123', 'Perawat');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lapresume`
--
ALTER TABLE `lapresume`
  ADD PRIMARY KEY (`No_RM`);

--
-- Indexes for table `tbdokter`
--
ALTER TABLE `tbdokter`
  ADD PRIMARY KEY (`Kode_Dokter`);

--
-- Indexes for table `tbpasien`
--
ALTER TABLE `tbpasien`
  ADD PRIMARY KEY (`No_RM`);

--
-- Indexes for table `tbperminresume`
--
ALTER TABLE `tbperminresume`
  ADD PRIMARY KEY (`No_RM`);

--
-- Indexes for table `tbresumemedis`
--
ALTER TABLE `tbresumemedis`
  ADD PRIMARY KEY (`No_RM`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
