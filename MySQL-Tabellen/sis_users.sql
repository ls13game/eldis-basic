-- phpMyAdmin SQL Dump
-- version 4.6.6deb4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 12. Mai 2020 um 20:30
-- Server-Version: 10.3.18-MariaDB-1:10.3.18+maria~stretch
-- PHP-Version: 7.0.33-0+deb9u7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `zap349503-1`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `sis_users`
--

CREATE TABLE `sis_users` (
  `id` int(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `passwort` text NOT NULL,
  `steamid` varchar(255) NOT NULL,
  `usertype` varchar(255) NOT NULL,
  `created_at` varchar(255) NOT NULL DEFAULT 'current_timestamp()',
  `fraktion` varchar(255) NOT NULL,
  `vorname` varchar(255) NOT NULL,
  `nachname` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;
--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `sis_users`
--
ALTER TABLE `sis_users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `sis_users`
--
ALTER TABLE `sis_users`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
