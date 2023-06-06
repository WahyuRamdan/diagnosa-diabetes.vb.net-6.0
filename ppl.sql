-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2023 at 10:05 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ppl`
--

-- --------------------------------------------------------

--
-- Table structure for table `basis_aturan`
--

CREATE TABLE `basis_aturan` (
  `id` int(8) NOT NULL,
  `id_gejala` varchar(200) NOT NULL,
  `pertanyaan` varchar(200) NOT NULL,
  `fakta` varchar(20) NOT NULL,
  `rute` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `id_penyakit` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `basis_aturan`
--

INSERT INTO `basis_aturan` (`id`, `id_gejala`, `pertanyaan`, `fakta`, `rute`, `status`, `id_penyakit`) VALUES
(1, 'isBanyakKencing', 'Apakah kencing di malam hari lebih dari 5 kali?', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(2, 'isSeringHausLapar', 'Sering haus atau lapar', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(3, 'isBeratBadanTurun', 'Berat badan turun drastis', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(4, 'isLukaSulitSembuh', 'Luka sulit/lama sembuh', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(5, 'isSeringCepatLelah', 'Sering cepat lelah saat beraktifitas', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(6, 'isHipertensi', 'Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(7, 'isBekerjaDenganKeringat', 'Berkeringat dengan keringat lengket', '', 'R1', '', 'Diabetes Mellitus Type 1'),
(8, 'isBanyakKencing', 'Apakah kencing di malam hari lebih dari 5 kali?', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(9, 'isSeringHausLapar', 'Sering haus atau lapar', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(10, 'isBeratBadanTurun', 'Berat badan turun drastis', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(11, 'isLukaSulitSembuh', 'Luka sulit/lama sembuh', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(12, 'isSeringCepatLelah', 'Sering cepat lelah saat beraktifitas', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(13, 'isObesitas', 'Obesitas (kegemukan)', '', 'R2', '', 'Diabetes Mellitus Type 2'),
(14, 'isBanyakKencing', 'Apakah kencing di malam hari lebih dari 5 kali?', '', 'R3', '', 'Neuropati Diabetes'),
(15, 'isSeringHausLapar', 'Sering haus atau lapar', '', 'R3', '', 'Neuropati Diabetes'),
(16, 'isSeringPusing', 'Sering pusing', '', 'R3', '', 'Neuropati Diabetes'),
(17, 'isPengelihatanKabur', 'Pengelihatan kabur', '', 'R3', '', 'Neuropati Diabetes'),
(18, 'isSeringMual', 'Sering mual-mual', '', 'R3', '', 'Neuropati Diabetes'),
(19, 'isObesitas', 'Obesitas (kegemukan)', '', 'R3', '', 'Neuropati Diabetes'),
(20, 'isKatarak', 'Katarak', '', 'R3', '', 'Neuropati Diabetes'),
(21, 'isSeringNyeriUluHati', 'Sering nyeri di ulu hati', '', 'R3', '', 'Neuropati Diabetes'),
(22, 'isBanyakKencing', 'Apakah kencing di malam hari lebih dari 5 kali?', '', 'R4', '', 'Retinopati Diabetes'),
(23, 'isPengelihatanKabur', 'Pengelihatan kabur', '', 'R4', '', 'Retinopati Diabetes'),
(24, 'isKesemutan', 'Sering kesemutan pada tangan dan kaki', '', 'R4', '', 'Retinopati Diabetes'),
(25, 'isSeringGatalAlergi', 'Sering gatal-gatal atau alergi pada kulit', '', 'R4', '', 'Retinopati Diabetes'),
(26, 'isHipertensi', 'Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)', '', 'R4', '', 'Retinopati Diabetes'),
(27, 'isBekerjaDenganKeringat', 'Berkeringat dengan keringat lengket', '', 'R4', '', 'Retinopati Diabetes'),
(28, 'isBanyakKencing', 'Apakah kencing di malam hari lebih dari 5 kali?', '', 'R5', '', 'Nefropati Diabetes'),
(29, 'isSeringHausLapar', 'Sering haus atau lapar', '', 'R5', '', 'Nefropati Diabetes'),
(30, 'isLukaSulitSembuh', 'Luka sulit/lama sembuh', '', 'R5', '', 'Nefropati Diabetes'),
(31, 'isInfeksiSaluranKemih', 'Infeksi salurah kemih', '', 'R5', '', 'Nefropati Diabetes'),
(32, 'isSeringNyeriPerut', 'Sering nyeri perut', '', 'R5', '', 'Nefropati Diabetes'),
(33, 'isHipertensi', 'Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)', '', 'R5', '', 'Nefropati Diabetes'),
(34, 'isObesitas', 'Obesitas (kegemukan)', '', 'R5', '', 'Nefropati Diabetes'),
(35, 'isSeringDiare', 'Sering diare', '', 'R5', '', 'Nefropati Diabetes'),
(36, 'isSeringPusing', 'Sering pusing', '', 'R6', '', 'Ketoasidosis Diabetes'),
(37, 'isKeputihan', 'Keputihan', '', 'R6', '', 'Ketoasidosis Diabetes'),
(38, 'isSeringMuntah', 'Sering muntah', '', 'R6', '', 'Ketoasidosis Diabetes'),
(39, 'isSeringNyeriPerut', 'Sering nyeri perut', '', 'R6', '', 'Ketoasidosis Diabetes'),
(40, 'isHipertensi', 'Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)', '', 'R6', '', 'Ketoasidosis Diabetes'),
(41, 'isObesitas', 'Obesitas (kegemukan)', '', 'R6', '', 'Ketoasidosis Diabetes'),
(42, 'isSeringDiare', 'Sering diare', '', 'R6', '', 'Ketoasidosis Diabetes'),
(43, 'isPengelihatanKabur', 'Pengelihatan kabur', '', 'R7', '', 'Gestasional Diabetes'),
(44, 'isSeringMual', 'Sering mual-mual', '', 'R7', '', 'Gestasional Diabetes'),
(45, 'isSeringMuntah', 'Sering muntah', '', 'R7', '', 'Gestasional Diabetes'),
(46, 'isSeringNyeriPerut', 'Sering nyeri perut', '', 'R7', '', 'Gestasional Diabetes'),
(47, 'isObesitas', 'Obesitas (kegemukan)', '', 'R7', '', 'Gestasional Diabetes'),
(48, 'isBekerjaDenganKeringat', 'Berkeringat dengan keringat lengket', '', 'R7', '', 'Gestasional Diabetes'),
(49, 'isSeringNyeriUluHati', 'Sering nyeri di ulu hati', '', 'R7', '', 'Gestasional Diabetes');

-- --------------------------------------------------------

--
-- Table structure for table `daftar_penyakit`
--

CREATE TABLE `daftar_penyakit` (
  `id_penyakit` int(8) NOT NULL,
  `nama_penyakit` varchar(200) NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `np_penyakit` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `daftar_penyakit`
--

INSERT INTO `daftar_penyakit` (`id_penyakit`, `nama_penyakit`, `keterangan`, `np_penyakit`) VALUES
(1, 'Diabetes Mellitus Type 1', 'Diabetes Mellitus Tipe 1 adalah penyakit autoimun di mana sistem kekebalan tubuh menghancurkan sel-sel penghasil insulin di pankreas. Sebagai respons, tubuh tidak dapat memproduksi insulin yang cukup,', 0),
(2, 'Diabetes Mellitus Type 2', '', 0),
(3, 'Neuropati Diabetes', '', 0),
(4, 'Retinopati Diabetes', '', 0),
(5, 'Nefropati Diabetes', '', 0),
(6, 'Ketoasidosis Diabetes', '', 0),
(7, 'Gestasional Diabetes', '', 0),
(8, 'Tidak memiliki diabetes', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `daftar_solusi`
--

CREATE TABLE `daftar_solusi` (
  `id_solusi` int(8) NOT NULL,
  `solusi` varchar(2000) NOT NULL,
  `id_penyakit` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `daftar_solusi`
--

INSERT INTO `daftar_solusi` (`id_solusi`, `solusi`, `id_penyakit`) VALUES
(1, 'Pengobatan pada diabetes tipe 1 bertujuan untuk menjaga kadar gula darah tetap normal dan mencegah terjadinya komplikasi. Metode pengobatannya bisa meliputi:\n\nPerubahan pola hidup\nPemberian insulin\nPenggunaan obat-obatan\nPemantauan kadar gula darah', 'Diabetes Mellitus Type 1'),
(2, 'Metode untuk menangani diabetes tipe 2 meliputi penerapan pola hidup dan pola makan sehat, serta pemberian obat atau insulin. Sambil tetap menjalani pengobatan, pasien perlu menjalani tes gula darah dan pemeriksaan kesehatan rutin.\r\n\r\nDiabetes tipe 2 dapat dicegah dengan menerapkan pola hidup sehat berikut:\r\n\r\nMengonsumsi makanan bergizi lengkap dan seimbang\r\nMemilih makanan tinggi serat, rendah lemak dan rendah kalori\r\nMenghindari konsumsi makanan yang mengandung gula dan lemak tinggi\r\nBerolahraga rutin\r\nMenjaga berat badan ideal', 'Diabetes Mellitus Type 2'),
(3, 'Pengobatan neuropati diabetik bertujuan untuk meredakan nyeri, serta mengembalikan fungsi normal saraf tubuh. Agar lebih jelas, simak penjelasan di bawah ini:\r\n\r\nMeredakan nyeri\r\nGuna meredakan nyeri yang timbul akibat neuropati diabetik, dokter bisa meresepkan:\r\n\r\nAntidepresan, seperti amitriptyline dan duloxetine\r\nAntikejang, seperti gabapentin, carbamazepine, dan pregabalin\r\nKrim berisi capsaicin', 'Neuropati Diabetes'),
(4, 'Pengobatan retinopati diabetik tergantung pada tingkat keparahannya. Pada pasien retinopati diabetik tahap awal, pengobatan belum diperlukan. Meski demikian, dokter akan menganjurkan pasien untuk mengontrol kadar gula darah dan kesehatan mata secara berkala.\r\n\r\nSedangkan pada kasus retinopati diabetik tahap lanjut, dokter dapat menyarankan sejumlah prosedur medis, yaitu:\r\n\r\nSuntik obat ke dalam mata\r\nDokter akan menyuntikkan obat langsung ke dalam bola mata, untuk mencegah pembentukan pembuluh darah baru. Obat yang diberikan adalah bevacizumab.\r\nVitrektomi\r\nVitrektomi dilakukan dengan membuat irisan kecil pada mata. Tujuannya adalah untuk mengeluarkan darah dan mengangkat jaringan parut dari bagian tengah mata.\r\nFotokoagulasi\r\nFotokoagulasi adalah terapi sinar laser untuk memperlambat atau menghentikan kebocoran cairan dan darah di dalam bola mata. Terapi ini dilakukan dengan menembakkan sinar laser secara terfokus pada pembuluh darah yang abnormal.', 'Retinopati Diabetes'),
(5, 'Nefropati diabetik tidak bisa sembuh total, tetapi perburukannya dapat dicegah dengan mengendalikan kadar gula darah dan tekanan darah. Metode pengobatannya adalah dengan pemberian obat-obatan, seperti:\r\n\r\nObat penghambat enzim pengubah angiotensin (ACE inhibitor) atau ARB (angiotensin II receptor blocker), seperti captopril,atau ARB (angiotensin II receptor blocker), seperti irbesartan, untuk menurunkan tekanan darah tinggi sekaligus menahan bocornya albumin ke urine\r\nObat penurun kolesterol, seperti statin, untuk menurunkan kadar kolesterol dan mengurangi kebocoran protein ke urine (ginjal bocor)\r\nInsulin, untuk menurunkan kadar gula darah\r\nFinerenone, untuk mengurangi risiko peradangan pada ginjal', 'Nefropati Diabetes'),
(6, 'Tujuan pengobatan ketoasidosis diabetik adalah untuk menstabilkan kondisi pasien, mengatasi kondisi asidosis, dan memastikan agar kondisi tersebut tidak terulang kembali. Oleh karena itu, pasien ketoasidosis diabetik dianjurkan untuk menjalani rawat inap di rumah sakit.\r\n\r\nTerapi yang dilakukan oleh dokter untuk menstabilkan kondisi pasien dan mengobati ketoasidosis diabetik adalah:\r\n\r\nMemberikan terapi cairan melalui infus, untuk mengatasi dehidrasi dan mengencerkan glukosa dalam darah\r\nMemberikan insulin melalui infus, yang dilanjutkan dengan pemberian insulin melalui suntikan di bawah kulit untuk menurunkan kadar gula darah\r\nMemberikan pengganti elektrolit, seperti kalium, natrium, dan klorida untuk menyeimbangkan kadar elektrolit tubuh\r\nMemberikan obat-obatan untuk mengatasi penyebab ketoasidosis diabetik, misalnya memberikan antibiotik jika terjadi infeksi', 'Ketoasidosis Diabetes'),
(7, 'Tenaga kesehatan medis, dapat membantu Anda dengan memantau gula darah, memberikan tips makan makanan sehat dan melakukan aktivitas fisik. Ada tiga komponen dasar dalam mengelola diabetes gestasional secara efektif:\r\n\r\nMemonitor kadar glukosa darah\r\nMenjalankan pola makan yang sehat\r\nMelakukan aktivitas fisik.', 'Gestasional Diabetes'),
(8, 'Tetap menjaga kadar gula yang sehat ', 'Tidak memiliki diabetes');

-- --------------------------------------------------------

--
-- Table structure for table `gejala`
--

CREATE TABLE `gejala` (
  `id_gejala` varchar(20) NOT NULL,
  `gejala` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gejala`
--

INSERT INTO `gejala` (`id_gejala`, `gejala`) VALUES
('G01', 'Apakah kencing di malam hari lebih dari 5 kali?'),
('G02', 'Sering haus atau lapar'),
('G03', 'Berat badan turun drastis'),
('G04', 'Sering pusing'),
('G05', 'Luka sulit/lama sembuh'),
('G06', 'Pengelihatan kabur'),
('G07', 'Keputihan'),
('G08', 'Sering kesemutan pada tangan dan kaki'),
('G09', 'Sering cepat lelah saat beraktifitas'),
('G10', 'Infeksi salurah kemih'),
('G11', 'Sering gatal-gatal atau alergi pada kulit'),
('G12', 'Sering mual-mual'),
('G13', 'Sering muntah'),
('G14', 'Sering nyeri perut'),
('G15', 'Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)'),
('G16', 'Obesitas (kegemukan)'),
('G17', 'Katarak'),
('G18', 'Berkeringat dengan keringat lengket'),
('G19', 'Sering diare'),
('G20', 'Sering sesak nafas'),
('G21', 'Sering nyeri di ulu hati');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `jenis_kelamin` varchar(200) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `tgl_diagnosa` date NOT NULL,
  `keterangan` varchar(200) NOT NULL,
  `hasil_diagnosa` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `nama`, `password`, `jenis_kelamin`, `tgl_lahir`, `tgl_diagnosa`, `keterangan`, `hasil_diagnosa`) VALUES
(1, 'wahyuramdan', '123', 'pria', '2023-05-22', '2023-05-22', 'admin', ''),
(3, 'eriko', 'erikonjir', 'Pria', '2023-05-17', '2023-05-31', 'user', 'Diabetes Mellitus Type 1'),
(12, 'nero', 'zoki', 'Wanita', '2023-05-23', '2023-05-23', 'user', '123'),
(13, 'winda', 'winda', 'Pria', '2023-05-29', '2023-05-29', 'user', ''),
(14, 'fauzan', '123', 'Pria', '2023-05-31', '2023-05-31', 'user', 'Diabetes Mellitus Type 1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `basis_aturan`
--
ALTER TABLE `basis_aturan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `daftar_penyakit`
--
ALTER TABLE `daftar_penyakit`
  ADD PRIMARY KEY (`id_penyakit`);

--
-- Indexes for table `daftar_solusi`
--
ALTER TABLE `daftar_solusi`
  ADD PRIMARY KEY (`id_solusi`),
  ADD UNIQUE KEY `id_penyakit` (`id_penyakit`);

--
-- Indexes for table `gejala`
--
ALTER TABLE `gejala`
  ADD PRIMARY KEY (`id_gejala`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nama` (`nama`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `basis_aturan`
--
ALTER TABLE `basis_aturan`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `daftar_penyakit`
--
ALTER TABLE `daftar_penyakit`
  MODIFY `id_penyakit` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `daftar_solusi`
--
ALTER TABLE `daftar_solusi`
  MODIFY `id_solusi` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
