-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 12 Lis 2018, 14:42
-- Wersja serwera: 10.1.35-MariaDB
-- Wersja PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `blog`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `article`
--

CREATE TABLE `article` (
  `id` int(11) NOT NULL,
  `title` text NOT NULL,
  `image` text NOT NULL,
  `content` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `article`
--

INSERT INTO `article` (`id`, `title`, `image`, `content`) VALUES
(1, 'Jak wysłać e-mail', 'http://placehold.it/350x150', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam fermentum et lorem at volutpat. Ut hendrerit fermentum tellus et congue. Proin porta tristique arcu in laoreet. Donec lacinia dictum dolor non cursus. Praesent vitae augue ac turpis porta dapibus. Fusce eleifend ante vel mauris porta suscipit. Quisque congue fermentum vehicula. Vestibulum in augue malesuada, sollicitudin dui sed, vehicula lectus. In id ex vitae orci commodo ultricies. Nulla et accumsan felis, vel iaculis turpis. Aenean lacus est, pretium sagittis nisl sit amet, ullamcorper venenatis neque. Proin mollis facilisis dictum. Quisque laoreet diam augue, quis sagittis velit interdum id. Suspendisse a rhoncus ex. Proin facilisis ac massa vel dapibus. Nullam viverra et ipsum nec hendrerit.'),
(2, 'Co zrobić z polskimi znakami?', 'http://placehold.it/350x150', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam fermentum et lorem at volutpat. Ut hendrerit fermentum tellus et congue. Proin porta tristique arcu in laoreet. Donec lacinia dictum dolor non cursus. Praesent vitae augue ac turpis porta dapibus. Fusce eleifend ante vel mauris porta suscipit. Quisque congue fermentum vehicula. Vestibulum in augue malesuada, sollicitudin dui sed, vehicula lectus. In id ex vitae orci commodo ultricies. Nulla et accumsan felis, vel iaculis turpis. Aenean lacus est, pretium sagittis nisl sit amet, ullamcorper venenatis neque. Proin mollis facilisis dictum. Quisque laoreet diam augue, quis sagittis velit interdum id. Suspendisse a rhoncus ex. Proin facilisis ac massa vel dapibus. Nullam viverra et ipsum nec hendrerit.');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `article`
--
ALTER TABLE `article`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `article`
--
ALTER TABLE `article`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
