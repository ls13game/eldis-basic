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
-- Tabellenstruktur für Tabelle `sis_fw_einsatz`
--

CREATE TABLE `sis_fw_einsatz` (
  `einsatznummer` int(255) NOT NULL,
  `alarmstufe` varchar(255) NOT NULL DEFAULT '''''',
  `meldebild` varchar(255) NOT NULL DEFAULT '',
  `datum` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `straße` varchar(255) NOT NULL DEFAULT '''''',
  `nr` varchar(255) NOT NULL DEFAULT '''''',
  `plz` varchar(255) NOT NULL DEFAULT '''''',
  `stadt` varchar(255) NOT NULL DEFAULT '''''',
  `einsatzort` varchar(255) NOT NULL DEFAULT '''''',
  `disponent` varchar(255) NOT NULL,
  `einsatzleiter` varchar(255) NOT NULL DEFAULT '''''',
  `situation_am_einsatzort` varchar(255) NOT NULL DEFAULT '''''',
  `tätigkeiten_am_einsatzort` varchar(255) NOT NULL DEFAULT '''''',
  `verbrauchsmaterial` varchar(255) NOT NULL DEFAULT '''''',
  `interne_notizen` varchar(255) NOT NULL DEFAULT '''''',
  `externe_notizen` varchar(255) NOT NULL DEFAULT '''''',
  `lagemeldung` varchar(255) NOT NULL DEFAULT '''''',
  `islocked` varchar(255) NOT NULL,
  `idlocked` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Daten für Tabelle `sis_fw_einsatz`
--

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `sis_fw_einsatz`
--
ALTER TABLE `sis_fw_einsatz`
  ADD PRIMARY KEY (`einsatznummer`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `sis_fw_einsatz`
--
ALTER TABLE `sis_fw_einsatz`
  MODIFY `einsatznummer` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
