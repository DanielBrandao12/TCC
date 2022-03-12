-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 09-Maio-2019 às 02:52
-- Versão do servidor: 10.1.37-MariaDB
-- versão do PHP: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mecanica`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_agenda`
--

CREATE TABLE `mec_tb_agenda` (
  `agen_in_codigo` int(11) NOT NULL,
  `Pes_in_codigo` int(11) NOT NULL,
  `usu_in_codigo` int(11) NOT NULL,
  `agen_dt_data` date DEFAULT NULL,
  `agen_tm_hora` time DEFAULT NULL,
  `agen_st_descricao` varchar(200) DEFAULT NULL,
  `agen_st_nome` varchar(50) DEFAULT NULL,
  `agen_in_contato` varchar(11) DEFAULT NULL,
  `agen_in_funcionario` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_agenda`
--

INSERT INTO `mec_tb_agenda` (`agen_in_codigo`, `Pes_in_codigo`, `usu_in_codigo`, `agen_dt_data`, `agen_tm_hora`, `agen_st_descricao`, `agen_st_nome`, `agen_in_contato`, `agen_in_funcionario`) VALUES
(1, 18, 2, '2019-05-08', '19:39:06', 'Trocar Filtro de olho', 'Enzo Cláudio da Rocha', '(21)9 8829-', 'Caio'),
(2, 17, 6, '2019-05-10', '19:39:06', 'Verificar vazamento de ólho', 'Giovana Priscila Analu Bernardes', '(95)9 9130-', 'Ronaldo'),
(3, 7, 1, '2019-05-17', '03:00:00', 'Verificar Radiador', 'Pedro Henrique Gustavo Martin Aparício', '(82)9 9894-', 'Brendo'),
(4, 5, 1, '2019-05-08', '10:30:00', 'Limpeza de bico', 'Elias Igor Osvaldo Rocha', '(69)9 8758-', 'Brendo'),
(5, 19, 7, '2019-05-09', '11:30:00', 'Ttrocar Correia dentada', 'Murilo José Diego Lima', '(83)9 8844-', 'Claudio'),
(6, 19, 6, '2019-05-08', '12:50:00', 'Revisão de 1000km', 'Murilo José Diego Lima', '(83)9 8844-', 'Ronaldo'),
(7, 18, 2, '2019-05-08', '13:45:00', 'Trocar Filtro de olho', 'Enzo Cláudio da Rocha', '(21)9 8829-', 'Caio'),
(8, 17, 7, '2019-05-09', '09:30:00', 'Trocar Cabo de véla', 'Giovana Priscila Analu Bernardes', '(95)9 9130-', 'Claudio'),
(9, 20, 6, '2019-05-08', '19:51:51', 'Trocar a bomba de olho', 'Eduardo Paulo Enzo das Neves', '(14)9 8373-', 'Ronaldo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_avalia`
--

CREATE TABLE `mec_tb_avalia` (
  `av_in_codigo` int(11) NOT NULL,
  `usu_in_codigo` int(11) DEFAULT NULL,
  `av_st_assunto` varchar(200) DEFAULT NULL,
  `av_st_comentario` varchar(200) DEFAULT NULL,
  `av_dt_dataHora` datetime DEFAULT NULL,
  `av_in_qntEstrela` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Acionadores `mec_tb_avalia`
--
DELIMITER $$
CREATE TRIGGER `mec_TG_dataAv` BEFORE INSERT ON `mec_tb_avalia` FOR EACH ROW SET NEW.av_dt_dataHora= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_contaspagar`
--

CREATE TABLE `mec_tb_contaspagar` (
  `ContaP_in_codigo` int(11) NOT NULL,
  `pes_in_codigo` int(11) DEFAULT NULL,
  `ContaP_st_status` varchar(50) DEFAULT NULL,
  `ContaP_re_totalPag` double(10,2) DEFAULT NULL,
  `ContaP_re_juros` int(11) DEFAULT NULL,
  `ContaP_st_formaPag` varchar(20) DEFAULT NULL,
  `Contap_st_observacao` varchar(200) DEFAULT NULL,
  `ContaP_date_dataVenc` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_contaspagar`
--

INSERT INTO `mec_tb_contaspagar` (`ContaP_in_codigo`, `pes_in_codigo`, `ContaP_st_status`, `ContaP_re_totalPag`, `ContaP_re_juros`, `ContaP_st_formaPag`, `Contap_st_observacao`, `ContaP_date_dataVenc`) VALUES
(1, 21, 'Pago', 655.00, 0, 'A vista', '', '2019-05-08'),
(2, 22, 'Pago', 325.50, 0, 'A vista', '', '2019-05-08'),
(3, 23, 'A pagar', 1593.24, 2, 'Parcelado', 'Cada parcela será na mesma data mês a mês', '2019-05-08');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_contasreceber`
--

CREATE TABLE `mec_tb_contasreceber` (
  `ContaR_in_codigo` int(11) NOT NULL,
  `venda_in_codigo` int(11) DEFAULT NULL,
  `ContaR_st_status` varchar(20) DEFAULT NULL,
  `ContaR_date_dataVenc` date DEFAULT NULL,
  `ContaR_re_totalPag` double(10,2) DEFAULT NULL,
  `ContaR_re_juros` double(10,2) DEFAULT NULL,
  `ContaR_st_formaPag` varchar(20) DEFAULT NULL,
  `ContaR_st_observacao` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_contasreceber`
--

INSERT INTO `mec_tb_contasreceber` (`ContaR_in_codigo`, `venda_in_codigo`, `ContaR_st_status`, `ContaR_date_dataVenc`, `ContaR_re_totalPag`, `ContaR_re_juros`, `ContaR_st_formaPag`, `ContaR_st_observacao`) VALUES
(1, 1, 'Pago', '2019-05-08', 127.30, 0.00, 'A Vista', ''),
(2, 2, 'Pago', '2019-05-08', 495.50, 0.00, 'A Vista', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_contato`
--

CREATE TABLE `mec_tb_contato` (
  `cont_in_codigo` int(11) NOT NULL,
  `pes_in_codigo` int(11) DEFAULT NULL,
  `cont_in_tel` varchar(20) DEFAULT NULL,
  `cont_in_cel` varchar(20) DEFAULT NULL,
  `cont_st_email` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_contato`
--

INSERT INTO `mec_tb_contato` (`cont_in_codigo`, `pes_in_codigo`, `cont_in_tel`, `cont_in_cel`, `cont_st_email`) VALUES
(1, 1, '(91)2535-2425', '(91)9 8938-2558', 'sseverinogiovannisan'),
(2, 2, '(96)3963-4069', '(96)9 8926-7635', 'simonealiciabaptista'),
(3, 3, '(84)2916-6403', '(84)9 8134-0753', 'bentoleandronovaes..'),
(4, 4, '(83)3987-4307', '(83)9 8767-5464', 'aandreafranciscaelis'),
(5, 5, '(69)3648-6577', '(69)9 8758-3082', 'eliasigorosvaldoroch'),
(6, 6, '(92)3916-9269', '(92)9 8596-9451', 'jaquelinecarolinajes'),
(7, 7, '(82)3784-5858', '(82)9 9894-6824', 'pedrohenriquegustavo'),
(8, 8, '(22)3905-8286', '(22)9 8489-2718', 'nicolesophieritagalv'),
(9, 9, '(11)3733-5175', '(11)9 8670-5641', 'nnicoleisisclaricedu'),
(10, 10, '(83)3908-6295', '(83)9 9264-9458', 'matheuseliaspedrofig'),
(11, 11, '(63)2777-4534', '(63)9 8193-0537', 'caiomateusaragao-98@'),
(12, 12, '(68)3806-6201', '(68)9 8641-4417', 'llevitomasaragao@sim'),
(13, 13, '(62)3841-9411', '(62)9 8673-0608', 'mirellarebecavitoria'),
(14, 14, '(54)3674-6193', '(54)9 9793-3139', 'hheloisegiovanafigue'),
(15, 15, '(65)3766-4568', '(65)9 8695-9375', 'vitoriadanielaolivei'),
(16, 16, '(51)3805-7464', '(51)9 8707-7459', 'mmilenamalumonteiro@'),
(17, 17, '(95)2804-0165', '(95)9 9130-5089', 'giovanapriscilaanalu'),
(18, 18, '(21)3545-1244', '(21)9 8829-8717', 'enzoclaudiodarocha__'),
(19, 19, '(83)2867-9370', '(83)9 8844-4330', 'murilojosediegolima_'),
(20, 20, '(14)2835-0088', '(14)9 8373-0513', 'eeduardopauloenzodas'),
(21, 21, '(12)2673-1049', '(12)9 9620-2681', 'financeiro@isabellae'),
(22, 22, '(18)3783-8430', '(18)9 8305-0101', 'producao@raimundoema'),
(23, 23, '(19)3550-6321', '(19)9 8965-8836', 'financeiro@nairejoan'),
(24, 24, '(11)3999-2067', '(11)9 8957-8255', 'comunicacoes@erickes'),
(25, 25, '(19)3921-5472', '(19)9 9255-8195', 'comunicacoes@sophiae'),
(26, 26, '(11)3882-9283', '(11)9 9223-1548', 'juridico@robertoemig'),
(27, 27, '(11)2533-2370', '(11)9 8483-7379', 'pesquisa@erickeyasmi'),
(28, 28, '(18)3971-6572', '(18)9 9580-7777', 'manutencao@beneditoe'),
(29, 29, '(11)3875-1759', '(11)9 8714-5535', 'financeiro@thalesera'),
(30, 30, '(11)3994-5244', '(11)9 8203-2113', 'desenvolvimento@heit'),
(31, 31, '(11)2529-5636', '(11)9 8979-4998', 'manutencao@laiseisab'),
(32, 32, '(17)2705-9914', '(17)9 9636-7602', 'rh@pietraebenjaminen'),
(33, 33, '(14)3822-1337', '(14)9 8156-8637', 'www.calebeesoniabuff'),
(34, 34, '(13)3613-9475', '(13)9 8624-6041', 'financeiro@joseepedr'),
(35, 35, '(19)2870-2358', '(19)9 9778-5833', 'ti@beatrizekevincons'),
(36, 36, '(11)3825-4681', '(11)9 8562-9586', 'faleconosco@lucianae'),
(37, 37, '(16)2502-3203', '(16)9 9301-3573', 'estoque@heitorevicen'),
(38, 38, '(16)2769-7220', '(16)9 8848-5289', 'fiscal@diogoeemanuel'),
(39, 39, '(11)2636-3847', '(11)9 9253-2100', 'representantes@evely'),
(40, 40, '(13)3963-8390', '(13)9 8306-4715', 'rh@matheuseelisapubl');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_imagens`
--

CREATE TABLE `mec_tb_imagens` (
  `img_in_codigo` int(11) NOT NULL,
  `usu_in_codigo` int(11) NOT NULL,
  `img_dt_data` date DEFAULT NULL,
  `img_st_imagem` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_imagens`
--

INSERT INTO `mec_tb_imagens` (`img_in_codigo`, `usu_in_codigo`, `img_dt_data`, `img_st_imagem`) VALUES
(1, 9, '2019-05-08', '2a4683fbb248fb8de66210e86d73ef65.png'),
(2, 8, '2019-05-08', 'df765d75ef297f39360ea94d79109040.png'),
(3, 10, '2019-05-08', 'df51e00ad183c1f5ccb4aa8f19ad4411.png'),
(4, 11, '2019-05-08', '855f97785170e992d026220eadc0d2ab.png'),
(5, 12, '2019-05-08', 'b7da7a486def55f864d8dd597a93a515.png'),
(6, 13, '2019-05-08', 'f531091f4a9bd663d3fbff44081fc6cc.png'),
(7, 14, '2019-05-08', '7a575d788e7b70e8950a1ceb6566b4ed.png'),
(8, 15, '2019-05-08', '7e5e6dc59397e290ffa09f7126c1ae75.png'),
(9, 16, '2019-05-08', '39f59cfcf2c763621c01e045c5ac8229.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_itemparcela`
--

CREATE TABLE `mec_tb_itemparcela` (
  `ItemParc_in_codigo` int(11) NOT NULL,
  `Venda_in_codigo` int(11) DEFAULT NULL,
  `ContaP_in_codigo` int(11) DEFAULT NULL,
  `ItemParc_in_numeroParc` int(11) DEFAULT NULL,
  `ItemParc_re_Valor` double(10,2) DEFAULT NULL,
  `ItemParc_date_dataVenc` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_itemparcela`
--

INSERT INTO `mec_tb_itemparcela` (`ItemParc_in_codigo`, `Venda_in_codigo`, `ContaP_in_codigo`, `ItemParc_in_numeroParc`, `ItemParc_re_Valor`, `ItemParc_date_dataVenc`) VALUES
(1, NULL, 3, 3, 531.08, '2019-06-08');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_itemven`
--

CREATE TABLE `mec_tb_itemven` (
  `Item_int_codigo` int(11) NOT NULL,
  `Venda_in_codigo` int(11) DEFAULT NULL,
  `Item_int_qtde` int(11) DEFAULT NULL,
  `Prod_in_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_itemven`
--

INSERT INTO `mec_tb_itemven` (`Item_int_codigo`, `Venda_in_codigo`, `Item_int_qtde`, `Prod_in_codigo`) VALUES
(1, 1, 1, 20),
(2, 1, 1, 6),
(3, 2, 1, 13);

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_movimenta`
--

CREATE TABLE `mec_tb_movimenta` (
  `Mov_in_codigo` int(10) NOT NULL,
  `Prod_in_codigo` int(11) DEFAULT NULL,
  `Mov_st_Tipo` varchar(25) DEFAULT NULL,
  `Mov_in_QtdeAtual` int(11) DEFAULT NULL,
  `Mov_in_QtdeAnterior` int(11) DEFAULT NULL,
  `Mov_in_QtdeNova` int(11) DEFAULT NULL,
  `Mov_date_data` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `mec_tb_movimenta`
--

INSERT INTO `mec_tb_movimenta` (`Mov_in_codigo`, `Prod_in_codigo`, `Mov_st_Tipo`, `Mov_in_QtdeAtual`, `Mov_in_QtdeAnterior`, `Mov_in_QtdeNova`, `Mov_date_data`) VALUES
(1, 1, 'Entrada', 100, 0, 100, '2019-05-08'),
(2, 2, 'Entrada', 50, 0, 50, '2019-05-08'),
(3, 20, 'Saída', 1, 3, 2, '2019-05-08'),
(4, 6, 'Saída', 1, 5, 4, '2019-05-08'),
(5, 13, 'Saída', 1, 20, 19, '2019-05-08');

--
-- Acionadores `mec_tb_movimenta`
--
DELIMITER $$
CREATE TRIGGER `mec_tg_dataMov` BEFORE INSERT ON `mec_tb_movimenta` FOR EACH ROW SET NEW.Mov_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_pessoas`
--

CREATE TABLE `mec_tb_pessoas` (
  `Pes_in_codigo` int(11) NOT NULL,
  `Pes_st_tipo` varchar(60) DEFAULT NULL,
  `Pes_st_Nome` varchar(200) DEFAULT NULL,
  `Pes_st_razaosocial` varchar(60) DEFAULT NULL,
  `Pes_st_nomefantasia` varchar(60) DEFAULT NULL,
  `Pes_in_cpf` varchar(50) DEFAULT NULL,
  `Pes_in_rg` int(11) DEFAULT NULL,
  `Pes_st_sexo` varchar(10) DEFAULT NULL,
  `Pes_st_bairro` varchar(30) DEFAULT NULL,
  `Pes_st_rua` varchar(60) DEFAULT NULL,
  `Pes_in_numero` varchar(35) DEFAULT NULL,
  `Pes_st_complemento` varchar(60) DEFAULT NULL,
  `Pes_st_cidade` varchar(30) DEFAULT NULL,
  `Pes_st_cnpj` varchar(30) DEFAULT NULL,
  `Pes_date_data` date DEFAULT NULL,
  `Pes_st_uf` varchar(10) DEFAULT NULL,
  `usu_in_codigo` int(11) DEFAULT NULL,
  `Pes_st_status` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_pessoas`
--

INSERT INTO `mec_tb_pessoas` (`Pes_in_codigo`, `Pes_st_tipo`, `Pes_st_Nome`, `Pes_st_razaosocial`, `Pes_st_nomefantasia`, `Pes_in_cpf`, `Pes_in_rg`, `Pes_st_sexo`, `Pes_st_bairro`, `Pes_st_rua`, `Pes_in_numero`, `Pes_st_complemento`, `Pes_st_cidade`, `Pes_st_cnpj`, `Pes_date_data`, `Pes_st_uf`, `usu_in_codigo`, `Pes_st_status`) VALUES
(1, 'Cliente', 'Severino Giovanni Santos', NULL, NULL, '264.804.418-34', NULL, 'Masculino', ' Célio Miranda', ' Rua Santo Antônio', '105', 'Apto 1', ' Paragominas', NULL, '2019-05-08', 'PA', NULL, NULL),
(2, 'Cliente', 'Simone Alícia Batista', NULL, NULL, '784.321.698-70', NULL, 'Feminino', ' Novo Buritizal', ' Rua Dezenove de Julho', '790', 'Casa', ' Macapá', NULL, '2019-05-08', 'AP', NULL, NULL),
(3, 'Cliente', 'Bento Leandro Novaes', NULL, NULL, '139.827.349-08', NULL, 'Masculino', ' Cidade Nova', ' Rua Francisco Varela', '220', 'Apto 25', ' Natal', NULL, '2019-05-08', 'RN', NULL, NULL),
(4, 'Cliente', 'Andrea Francisca Elisa Porto', NULL, NULL, '574.011.301-65', NULL, 'Feminino', ' Nações', ' Avenida Internacional', '393', 'Sobrado', ' Campina Grande', NULL, '2019-05-08', 'PB', NULL, NULL),
(5, 'Cliente', 'Elias Igor Osvaldo Rocha', NULL, NULL, '981.806.406-20', NULL, 'Masculino', ' Colina Park II', ' Rua Neumayer Pereira de Souza Junior', '473', 'Apto 4', ' Ji-Paraná', NULL, '2019-05-08', 'RO', NULL, NULL),
(6, 'Cliente', 'Jaqueline Carolina Jesus', NULL, NULL, '914.987.470-51', NULL, 'Feminino', ' Tancredo Neves', ' Rua Mundurucânia', '126', 'Apto 66', ' Manaus', NULL, '2019-05-08', 'AM', NULL, NULL),
(7, 'Cliente', 'Pedro Henrique Gustavo Martin Aparício', NULL, NULL, '020.163.461-91', NULL, 'Masculino', ' Clima Bom', ' Rua Manoel Gomes', '360', 'Casa dos Fundos', ' Maceió', NULL, '2019-05-08', 'AL', NULL, NULL),
(8, 'Cliente', 'Nicole Sophie Rita Galvão', NULL, NULL, '816.356.125-43', NULL, 'Feminino', ' São Marcos', ' Rua Maurício Ribeiro Bejamim', '193', 'Apto 1', ' Macaé', NULL, '2019-05-08', 'RJ', NULL, NULL),
(9, 'Cliente', 'Nicole Isis Clarice Duarte', NULL, NULL, '784.841.367-52', NULL, 'Feminino', ' Conceição', ' Rua Profeta Izaías', '102', 'Casa', ' Osasco', NULL, '2019-05-08', 'SP', NULL, NULL),
(10, 'Cliente', 'Matheus Elias Pedro Figueiredo', NULL, NULL, '636.722.925-67', NULL, 'Masculino', ' Gramame', ' Rua Ailton Medeiros de Morais', '963', 'Apto 3', ' João Pessoa', NULL, '2019-05-08', 'PB', NULL, NULL),
(11, 'Cliente', 'Caio Mateus Aragão', NULL, NULL, '364.037.052-02', NULL, 'Masculino', ' Jardim Taquari (Taquaralto)', ' Quadra T 32 Rua LO 1', '460', 'Casa 1', ' Palmas', NULL, '2019-05-08', 'TO', NULL, NULL),
(12, 'Cliente', 'Levi Tomás Aragão', NULL, NULL, '113.504.474-04', NULL, 'Masculino', ' Invasão da Seis de Agosto', ' Ramal Beira da Judia', '924', 'Casa 8', ' Rio Branco', NULL, '2019-05-08', 'AC', NULL, NULL),
(13, 'Cliente', 'Mirella Rebeca Vitória da Luz', NULL, NULL, '284.827.638-06', NULL, 'Feminino', ' Vila Redenção', ' Rua MG 2', '294', 'Apto 9', ' Goiânia', NULL, '2019-05-08', 'GO', NULL, NULL),
(14, 'Cliente', 'Heloise Giovana Figueiredo', NULL, NULL, '324.777.199-98', NULL, 'Feminino', ' Fátima', ' Rua Maranhão', '749', 'Apto 5', ' Erechim', NULL, '2019-05-08', 'RS', NULL, NULL),
(15, 'Cliente', 'Vitória Daniela Oliveira', NULL, NULL, '243.744.583-87', NULL, 'Feminino', ' Areão', ' Rua C', '302', 'Entrada 5', ' Cuiabá', NULL, '2019-05-08', 'MT', NULL, NULL),
(16, 'Cliente', 'Milena Malu Monteiro', NULL, NULL, '750.062.765-33', NULL, 'Feminino', ' Tamandaré', ' Rua do Exército', '966', 'Casa', ' Esteio', NULL, '2019-05-08', 'RS', NULL, NULL),
(17, 'Cliente', 'Giovana Priscila Analu Bernardes', NULL, NULL, '113.754.577-13', NULL, 'Feminino', ' Nossa Senhora Aparecida', ' Rua Madre Radgund', '166', 'Sobrado', ' Boa Vista', NULL, '2019-05-08', 'RR', NULL, NULL),
(18, 'Cliente', 'Enzo Cláudio da Rocha', NULL, NULL, '809.125.471-70', NULL, 'Masculino', ' Santa Isabel', ' Rua Deodorino de Azevedo Alves', '828', 'Entrada 2', ' São Gonçalo', NULL, '2019-05-08', 'RJ', NULL, NULL),
(19, 'Cliente', 'Murilo José Diego Lima', NULL, NULL, '221.860.556-27', NULL, 'Masculino', ' Mangabeira', ' Rua José Emídio de Lucena', '763', 'Apto 88', ' João Pessoa', NULL, '2019-05-08', 'PB', NULL, NULL),
(20, 'Cliente', 'Eduardo Paulo Enzo das Neves', NULL, NULL, '188.333.293-13', NULL, 'Masculino', ' Núcleo Habitacional Nova Marí', ' Rua Olga de Lima Bueno', '625', 'Casa', ' Marília', NULL, '2019-05-08', 'SP', NULL, NULL),
(21, 'Fornecedor', NULL, 'Isabella e Martin Contábil ME', 'Isabella e Martin Contábil ME', NULL, NULL, NULL, ' Vila Martinez', ' Rua Moisés Ruston', '532', 'Comado 4', ' Jacareí', '23.564.797/0001-55', '2019-05-08', 'SP', NULL, NULL),
(22, 'Fornecedor', NULL, 'Raimundo e Martin Pizzaria Ltda', 'Raimundo e Martin Pizzaria Ltda', NULL, NULL, NULL, ' Concórdia I', ' Rua Fernandes Facioli', '110', 'Comercio 3', ' Araçatuba', '992.605.190-00', '2019-05-08', 'SP', NULL, NULL),
(23, 'Fornecedor', NULL, 'Nair e Joana Eletrônica Ltda', 'Nair e Joana Eletrônica Ltda', NULL, NULL, NULL, ' Cidade Claret', ' Rua 21', '529', 'Comer 7', ' Rio Claro', '65.492.772/0001-33', '2019-05-08', 'SP', NULL, NULL),
(24, 'Fornecedor', NULL, 'Erick e Severino Vidros Ltda', 'Erick e Severino Vidros Ltda', NULL, NULL, NULL, ' Vila Mazzei', ' Travessa Flávio Januário Benguela', '622', 'Entra 27', ' São Paulo', '28.496.775/0001-19', '2019-05-08', 'SP', NULL, NULL),
(25, 'Fornecedor', NULL, 'Sophia e Juan Telecomunicações ME', 'Sophia e Juan Telecomunicações ME', NULL, NULL, NULL, ' Terras de Piracicaba', ' Rua Antônio Alli', '503', 'Sala 6', ' Piracicaba', '43.966.478/0001-83', '2019-05-08', 'SP', NULL, NULL),
(26, 'Fornecedor', NULL, 'Roberto e Miguel Entregas Expressas ME', 'Roberto e Miguel Entregas Expressas ME', NULL, NULL, NULL, ' Vila Caju', ' Rua Odilon de Almeida', '614', 'Sala 8', ' São Paulo', '38.802.164/0001-05', '2019-05-08', 'SP', NULL, NULL),
(27, 'Fornecedor', NULL, 'Erick e Yasmin Joalheria ME', 'Erick e Yasmin Joalheria ME', NULL, NULL, NULL, ' Indianópolis', ' Rua Diacui', '541', 'Sala 20', ' São Paulo', '67.935.315/0001-00', '2019-05-08', 'SP', NULL, NULL),
(28, 'Fornecedor', NULL, 'Benedito e Mariah Limpeza Ltda', 'Benedito e Mariah Limpeza Ltda', NULL, NULL, NULL, ' Jardim Cambuy', ' Rua Joaquim Pereira de Almeida', '633', 'Rua 8', ' Presidente Prudente', '66.029.701/0001-61', '2019-05-08', 'SP', NULL, NULL),
(29, 'Fornecedor', NULL, 'Thales e Rafaela Telas ME', 'Thales e Rafaela Telas ME', NULL, NULL, NULL, ' Jardim Ninho Verde II', ' Rua Rio Bravo', '197', 'Galpão 2', ' São Paulo', '12.174.897/0001-59', '2019-05-08', 'SP', NULL, NULL),
(30, 'Fornecedor', NULL, 'Heitor e Bárbara Pães e Doces ME', 'Heitor e Bárbara Pães e Doces ME', NULL, NULL, NULL, ' Vila Nilo', ' Rua Adalgisa', '388', 'Casa', ' São Paulo', '66.810.807/0001-06', '2019-05-08', 'SP', NULL, NULL),
(31, 'Fornecedor', NULL, 'Laís e Isabelly Lavanderia Ltda', 'Laís e Isabelly Lavanderia Ltda', NULL, NULL, NULL, ' Jardim Bom Retiro', ' Rua São Barnabé', '850', 'Galpão 1', ' Salto', '08.136.019/0001-71', '2019-05-08', 'SP', NULL, NULL),
(32, 'Fornecedor', NULL, 'Pietra e Benjamin Entulhos Ltda', 'Pietra e Benjamin Entulhos Ltda', NULL, NULL, NULL, ' Alto Sumaré', ' Avenida Nove de Julho', '553', 'Terreno Benjamin', ' Barretos', '48.003.358/0001-02', '2019-05-08', 'SP', NULL, NULL),
(33, 'Fornecedor', NULL, 'Calebe e Sônia Buffet ME', 'Calebe e Sônia Buffet ME', NULL, NULL, NULL, ' Parque Industrial Manchester', ' Avenida Francisco Massari', '689', 'Sala 2 e 3', ' Bauru', '78.570.688/0001-32', '2019-05-08', 'SP', NULL, NULL),
(34, 'Fornecedor', NULL, 'José e Pedro Henrique Advocacia ME', 'José e Pedro Henrique Advocacia ME', NULL, NULL, NULL, ' Marapé', ' Rua Saturnino de Brito, 215', '838', 'Sala 20', ' Santos', '97.108.048/0001-50', '2019-05-08', 'SP', NULL, NULL),
(35, 'Fornecedor', NULL, 'Beatriz e Kevin Consultoria Financeira Ltda', 'Beatriz e Kevin Consultoria Financeira Ltda', NULL, NULL, NULL, ' Jardim Santa Amália', ' Rua Armando Sarnes', '141', 'Sala 1', ' Campinas', '28.971.571/0001-92', '2019-05-08', 'SP', NULL, NULL),
(36, 'Fornecedor', NULL, 'Luciana e Juliana Pizzaria Delivery ME', 'Luciana e Juliana Pizzaria Delivery ME', NULL, NULL, NULL, ' Parque Novo Mundo', ' Rua Pedro Taques Pires', '967', 'Casa', ' São Paulo', '65.248.579/0001-51', '2019-05-08', 'SP', NULL, NULL),
(37, 'Fornecedor', NULL, 'Heitor e Vicente Casa Noturna Ltda', 'Heitor e Vicente Casa Noturna Ltda', NULL, NULL, NULL, ' Residencial Monte Carlo', ' Avenida Wilson Antonio Bovolin', '810', 'Prédio Azul', ' Matão', '17.415.593/0001-50', '2019-05-08', 'SP', NULL, NULL),
(38, 'Fornecedor', NULL, 'Diogo e Emanuelly Adega ME', 'Diogo e Emanuelly Adega ME', NULL, NULL, NULL, ' Quintino Facci I', ' Avenida Antônio da Costa Lima', '974', 'Galpão 3', ' Ribeirão Preto', '54.677.941/0001-93', '2019-05-08', 'SP', NULL, NULL),
(39, 'Fornecedor', NULL, 'Evelyn e Larissa Marcenaria Ltda', 'Evelyn e Larissa Marcenaria Ltda', NULL, NULL, NULL, ' Vila Cosmopolita', ' Rua Pacajas', '952', 'Galpão 10', ' São Paulo', '77.406.682/0001-61', '2019-05-08', 'SP', NULL, NULL),
(40, 'Fornecedor', NULL, 'Matheus e Elisa Publicidade e Propaganda Ltda', 'Matheus e Elisa Publicidade e Propaganda Ltda', NULL, NULL, NULL, ' Chico de Paula', ' Rua João Moreira Salles', '478', 'Sala 1', ' Santos', '20.627.415/0001-05', '2019-05-08', 'SP', NULL, NULL),
(41, 'Site', 'SÃ©rgio e Pedro Corretores Associados Ltda', 'SÃ©rgio e Pedro Oficina Mecanica Ltda', 'SÃ©rgio e Pedro Oficina Mecanica Ltda', NULL, NULL, NULL, 'Jardim Ipanema', 'Rua Elias Zaidan Maluf', ' 652', 'andar 1', 'Piracicaba', ' 06.510.664/0001-87', '2019-05-08', ' SP ', 9, NULL),
(42, 'Site', 'Luana e Caleb EletrÃ´nica Ltda', 'Multicar ', 'Multicar', NULL, NULL, NULL, 'Jardim Dona Regina', 'BARI, 570', ' 54', 'Rua ConsÃ­lia Pereira Costa', 'JARINU', ' 66.627.120/0001-21', '2019-05-08', ' SP ', 8, NULL),
(43, 'Site', 'Mauro', 'DW Centro Automotivo', 'DW Centro Automotivo', NULL, NULL, NULL, 'Conjunto Residencial Haroldo V', 'Viela Pupy', ' 913', 'Viela Pupy', 'Guarulhos', ' 77.065.691/0001-36', '2019-05-08', ' SP ', 10, NULL),
(44, 'Site', 'Severino e Evelyn Joalheria ME', 'Auto Brasil', 'Auto Brasil', NULL, NULL, NULL, 'Parque IpÃª', 'Rua JererÃ©', ' 907', 'Parque IpÃª', 'SÃ£o Paulo', ' 42.168.175/0001-52', '2019-05-08', ' SP ', 11, NULL),
(45, 'Site', 'leandro', 'Paulistinha', 'Paulistinha', NULL, NULL, NULL, 'Jardim Dona Regina', 'BARI, 570', ' 907', 'Parque IpÃª', 'JARINU', ' 39.268.950/0001-37', '2019-05-08', ' SP ', 12, NULL),
(46, 'Site', 'Augusto e Sandra Restaurante ME', 'Central Oficina', 'Central Oficina', NULL, NULL, NULL, 'Vila Acoreana', 'Travessa Porto', ' 737', 'Acoreana', 'PoÃ¡', ' 18226979000186', '2019-05-08', ' SP ', 13, NULL),
(47, 'Site', 'Allana e Diogo InformÃ¡tica Ltda', 'Oficina Gente Feliz', 'Oficina Gente Feliz', NULL, NULL, NULL, 'Parque da Felicidade', 'Rua Colibri', ' 612', 'Colibri', '', ' 83958929000155', '2019-05-08', ' SP ', 14, NULL),
(48, 'Site', 'Pietro e SÃ´nia EletrÃ´nica Ltda', 'Mecanicos Premiun', 'Mecanicos Premiun', NULL, NULL, NULL, 'Jardim Sipramar', 'Rua Valentim Lorenzetti', ' 857', 'Jardim Sipramar', 'SÃ£o Paulo', ' 12676881000144', '2019-05-08', ' SP ', 15, NULL),
(49, 'Site', 'SÃ©rgio e Brenda Lavanderia ME', 'Oficina', 'Oficina', NULL, NULL, NULL, 'Vila Roseira II', 'Rua Ayrton Senna', ' 383', 'Rua Ayrton Senna', 'SÃ£o Paulo', ' 50853018000104', '2019-05-08', ' SP ', 16, NULL);

--
-- Acionadores `mec_tb_pessoas`
--
DELIMITER $$
CREATE TRIGGER `mec_TG_data` BEFORE INSERT ON `mec_tb_pessoas` FOR EACH ROW SET NEW.Pes_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_produtos`
--

CREATE TABLE `mec_tb_produtos` (
  `prod_in_codigo` int(11) NOT NULL,
  `pes_in_codigo` int(11) DEFAULT NULL,
  `prod_st_nome` varchar(50) DEFAULT NULL,
  `prod_st_descricao` varchar(200) DEFAULT NULL,
  `prod_st_marca` varchar(200) DEFAULT NULL,
  `prod_re_valorcompra` double(10,2) DEFAULT NULL,
  `prod_re_valorvenda` double(10,2) DEFAULT NULL,
  `prod_re_quantidade` int(11) DEFAULT NULL,
  `prod_date_data` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_produtos`
--

INSERT INTO `mec_tb_produtos` (`prod_in_codigo`, `pes_in_codigo`, `prod_st_nome`, `prod_st_descricao`, `prod_st_marca`, `prod_re_valorcompra`, `prod_re_valorvenda`, `prod_re_quantidade`, `prod_date_data`) VALUES
(1, 21, 'Pistão comprar a preços atraentes', 'Comprimento (mm): 46,920,Diâmetro do cilindro [mm]: 76,50,Ø do parafuso [mm]: 17', 'MAHLE ORIGINAL ', 30.00, 40.00, 100, '2019-05-08'),
(2, 21, ' Amortecedor dianteiro ', 'Peugeot 806 1995 até 2000 - Gas Active - cada (unidade) - 35009G', ' Corven', 31.60, 50.00, 50, '2019-05-08'),
(3, 21, 'Óleo do câmbio', 'Syn Power Gear Oil - LS 75W-140 - 946 Ml - cada (unidade)', 'Valvoline', 9.53, 15.00, 20, '2019-05-08'),
(4, 21, 'Boia sensor de nivel tanque combustível ', 'Gol/Parati/Saveiro/Voyage 1989 até 1994 - Gasolina ', 'VDO ', 8.45, 10.00, 20, '2019-05-08'),
(5, 22, 'Amortecedor dianteiro ', 'Laguna 1994 em diante - Gas Active', 'Corven', 59.10, 80.00, 5, '2019-05-08'),
(6, 22, 'Vela de ignição ', 'Uno/Palio/Siena-8V fire flex-Brava e Doblò 1.6 16V - green', 'NGK', 8.92, 12.30, 4, '2019-05-08'),
(7, 22, 'Disco de freio', 'Corolla 2003 até 2008 - Fielder 2004 em diante - 4 furos ventilado - freio ABS - 255 mm - dianteiro - par ', 'Varga', 23.70, 30.50, 15, '2019-05-08'),
(8, 23, 'Cabo de vela ', 'Celta/Corsa/Prisma-Stilo/Palio-1.8 2003 em diante - S-10/Blazer- 2.4 -Meriva/Doblo/Idea - 8V flex - jogo', 'Bosch ', 10.50, 16.50, 15, '2019-05-08'),
(9, 23, 'Conector de válvula termostática ', ' Ranger 2.3 4x2 4cil. 1997 até 2001 - cada (unidade)', 'alternativo ', 81.60, 70.30, 15, '2019-05-08'),
(10, 23, 'Sapata de freio ', 'Fiesta 1996 até 2000 - Ka 1997 até 2007 - Celta - Prisma - jogo ', 'Bosch', 13.95, 15.00, 15, '2019-05-08'),
(11, 24, 'Filtro de ar do motor', 'Civic 1.8/2.0 2011 até 2016 - cada (unidade)', 'Wega filtros -', 2.71, 3.80, 10, '2019-05-08'),
(12, 24, 'Filtro de ar do motor', 'Astra 1999 até 2011 - Zafira 2001 até 2007 - Vectra flex - cada (unidade) ', 'Bosch', 2.76, 5.50, 5, '2019-05-08'),
(13, 24, 'Filtro de ar do motor', 'Corolla/Fielder 1.6/1.8 2002 até 2008 - cada (unidade)', 'Wega filtros ', 2.03, 430.00, 19, '2019-05-08'),
(14, 25, 'Capa de carro', '100% forrada - prata - cada (unidade) ', 'Jacaré -', 12.50, 15.80, 0, '2019-05-08'),
(15, 25, ' Tapete de borracha', 'Série 2 (tipo universal - ver detalhes) - Stratus 4 peças - preto - jogo', 'BRB Unicol', 4.83, 6.90, 50, '2019-05-08'),
(16, 25, ' Cinto de segurança', 'transversal ( universal 2 pontos) ', 'Dialp', 2.72, 30.00, 50, '2019-05-08'),
(17, 26, ' Kit lâmpada do farol ', ' H4 - 12V 60/55W - super branca 4200K - par', 'Certa', 2.99, 3.50, 10, '2019-05-08'),
(18, 26, ' Kit lâmpada do farol', ' H4 x2 - X-Treme Vision - 130% mais luz - 12V 55/60W - jogo', 'Philips', 17.90, 20.00, 9, '2019-05-08'),
(19, 27, 'Borracha da porta ', 'Fusca 1959 até 1996 - par', 'vw', 3.77, 5.80, 3, '2019-05-08'),
(20, 27, 'Boia sensor de nivel tanque combustível', 'Escort 1987 - com alarme - álcool - cada (unidade) ', 'Indebrás', 25.50, 30.00, 2, '2019-05-08'),
(21, 28, 'Protetor do cárter', 'Fusion 2006 até 2009 - não precisa do kit de instalação - preto - cada ', 'Alternative', 5.82, 6.90, 2, '2019-05-08'),
(22, 28, 'Protetor do cárter', 'Uno/Prêmio/Fiorino/Elba 1984 até 2010 - preto - cada (unidade)', 'Atos', 4.23, 6.80, 1, '2019-05-08');

--
-- Acionadores `mec_tb_produtos`
--
DELIMITER $$
CREATE TRIGGER `mec_tg_dataProd` BEFORE INSERT ON `mec_tb_produtos` FOR EACH ROW SET NEW.prod_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_relatorio`
--

CREATE TABLE `mec_tb_relatorio` (
  `rel_in_codigo` int(11) NOT NULL,
  `serv_in_codigo` int(11) DEFAULT NULL,
  `rel_st_descricao` varchar(200) DEFAULT NULL,
  `rel_int_kmatual` int(11) DEFAULT NULL,
  `rel_int_kmprevisto` int(11) DEFAULT NULL,
  `rel_st_observacoes` varchar(200) DEFAULT NULL,
  `rel_date_data` date DEFAULT NULL,
  `Pes_in_codifo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_relatorio`
--

INSERT INTO `mec_tb_relatorio` (`rel_in_codigo`, `serv_in_codigo`, `rel_st_descricao`, `rel_int_kmatual`, `rel_int_kmprevisto`, `rel_st_observacoes`, `rel_date_data`, `Pes_in_codifo`) VALUES
(1, 1, 'Trocou vela e boia', 12354, 13245, '', '2019-05-08', NULL),
(2, 2, 'Trocou filtro', 32025, 33200, '', '2019-05-08', NULL);

--
-- Acionadores `mec_tb_relatorio`
--
DELIMITER $$
CREATE TRIGGER `mec_tg_dataRela` BEFORE INSERT ON `mec_tb_relatorio` FOR EACH ROW SET NEW.rel_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_servicos`
--

CREATE TABLE `mec_tb_servicos` (
  `serv_in_codigo` int(11) NOT NULL,
  `venda_in_codigo` int(11) DEFAULT NULL,
  `vec_in_codigo` int(11) DEFAULT NULL,
  `serv_st_descricao` varchar(200) DEFAULT NULL,
  `Serv_re_Vdesc` decimal(10,2) DEFAULT NULL,
  `Serv_re_VServico` decimal(10,2) DEFAULT NULL,
  `Serv_date_data` date DEFAULT NULL,
  `pes_in_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_servicos`
--

INSERT INTO `mec_tb_servicos` (`serv_in_codigo`, `venda_in_codigo`, `vec_in_codigo`, `serv_st_descricao`, `Serv_re_Vdesc`, `Serv_re_VServico`, `Serv_date_data`, `pes_in_codigo`) VALUES
(1, 1, 1, 'Trocou vela e boia', '0.00', '85.00', '2019-05-08', 1),
(2, 2, 9, 'Trocou filtro', '0.00', '65.00', '2019-05-08', 9);

--
-- Acionadores `mec_tb_servicos`
--
DELIMITER $$
CREATE TRIGGER `mec_tg_dataServ` BEFORE INSERT ON `mec_tb_servicos` FOR EACH ROW SET NEW.Serv_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_usuario`
--

CREATE TABLE `mec_tb_usuario` (
  `usu_in_codigo` int(11) NOT NULL,
  `usu_st_login` varchar(100) NOT NULL,
  `usu_se_senha` varchar(100) NOT NULL,
  `usu_date_data` date DEFAULT NULL,
  `usu_st_tipo` varchar(30) DEFAULT NULL,
  `usu_st_status` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_usuario`
--

INSERT INTO `mec_tb_usuario` (`usu_in_codigo`, `usu_st_login`, `usu_se_senha`, `usu_date_data`, `usu_st_tipo`, `usu_st_status`) VALUES
(1, 'Brendo', 'py9Izb', '2019-05-08', 'Funcionario', 'Ativo'),
(2, 'Caio', 'r4hnyu', '2019-05-08', 'Funcionario', 'Ativo'),
(3, 'Katia', 'r4hnyu', '2019-05-08', 'Administrador', 'Ativo'),
(4, 'Julio', 'q9kda7', '2019-05-08', 'Administrador', 'Ativo'),
(5, 'João', '5fush2', '2019-05-08', 'Administrador', 'Ativo'),
(6, 'Ronaldo', '123', '2019-05-08', 'Funcionario', 'Ativo'),
(7, 'Claudio', 'g7x0se', '2019-05-08', 'Funcionario', 'Ativo'),
(8, 'Jose', '123', '2019-05-08', 'SuperAdm', NULL),
(9, 'amanda', '123', '2019-05-08', 'SuperAdm', NULL),
(10, 'Mauro', '123', '2019-05-08', 'SuperAdm', NULL),
(11, 'Rogerio', '123', '2019-05-08', 'SuperAdm', NULL),
(12, 'Leandro', '123', '2019-05-08', 'SuperAdm', NULL),
(13, 'Roberto', '123', '2019-05-08', 'SuperAdm', NULL),
(14, 'Joao', '123', '2019-05-08', 'SuperAdm', NULL),
(15, 'Marcelo', '123', '2019-05-08', 'SuperAdm', NULL),
(16, 'gustavo', '123', '2019-05-08', 'SuperAdm', NULL),
(17, 'tiago', '123', '2019-05-08', 'SuperAdm', NULL),
(18, 'Maria', '123', '2019-05-08', 'SuperAdm', NULL);

--
-- Acionadores `mec_tb_usuario`
--
DELIMITER $$
CREATE TRIGGER `mec_TG_dataAutomatica` BEFORE INSERT ON `mec_tb_usuario` FOR EACH ROW SET NEW.usu_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_veiculos`
--

CREATE TABLE `mec_tb_veiculos` (
  `vec_in_codigo` int(11) NOT NULL,
  `Pes_in_codigo` int(11) DEFAULT NULL,
  `Vec_st_tipo` varchar(30) DEFAULT NULL,
  `Vec_st_marca` varchar(20) DEFAULT NULL,
  `Vec_st_modelo` varchar(20) DEFAULT NULL,
  `Vec_st_placa` varchar(10) DEFAULT NULL,
  `Vec_in_ano` int(11) DEFAULT NULL,
  `Vec_date_data` datetime DEFAULT NULL,
  `Vec_st_foto` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_veiculos`
--

INSERT INTO `mec_tb_veiculos` (`vec_in_codigo`, `Pes_in_codigo`, `Vec_st_tipo`, `Vec_st_marca`, `Vec_st_modelo`, `Vec_st_placa`, `Vec_in_ano`, `Vec_date_data`, `Vec_st_foto`) VALUES
(1, 1, 'Carro', 'Volvo', 'V40 T-4', 'MVC-9670', 1998, '2019-05-08 17:38:05', NULL),
(2, 2, 'Carro', 'Plymouth', 'Gran Voyager LE 2.5', 'JKF-1366', 1992, '2019-05-08 17:38:35', NULL),
(3, 3, 'Carro', 'BMW', '318i/iA Compact 1.8 ', 'MUN-8007', 1994, '2019-05-08 17:39:29', NULL),
(4, 4, 'Carro', 'Citroen', 'C3 Tendance 1.5 Flex', 'MKB-1530', 2013, '2019-05-08 17:40:06', NULL),
(5, 5, 'Carro', 'Fiat', 'Strada/ Strada Worki', 'JVD-9037', 1999, '2019-05-08 17:40:43', NULL),
(6, 6, 'Carro', 'Fiat', 'UNO ATTRACTIVE 1.4 E', 'MNB-5907', 2012, '2019-05-08 17:41:36', NULL),
(7, 7, 'Carro', 'Fiat', 'Tempra SX 2.0 i.e. 8', 'KWZ-5209', 1996, '2019-05-08 17:42:05', NULL),
(8, 8, 'Carro', 'Hyundai', 'VERACRUZ GLS 3.8 4WD', 'MJC-0749', 2007, '2019-05-08 17:42:36', NULL),
(9, 9, 'Carro', 'Hyundai', 'Coup', 'MUU-1031', 1997, '2019-05-08 17:43:05', NULL),
(10, 10, 'Carro', 'Hyundai', 'Tucson 2.0 CRDi 16V ', 'NEM-9822', 2005, '2019-05-08 17:43:32', NULL),
(11, 11, 'Carro', 'Hyundai', 'Veloster 1.6 16V  14', 'MRH-4325', 2012, '2019-05-08 17:44:14', NULL),
(12, 12, 'Carro', 'Mitsubishi', 'Space Wagon GLXi 2.4', 'IQD-1019', 1999, '2019-05-08 17:45:14', NULL),
(13, 13, 'Carro', 'Nissan', 'MARCH SV 1.0 12V Fle', 'LUJ-1809', 2015, '2019-05-08 17:45:52', NULL),
(14, 14, 'Carro', 'Nissan', 'Maxima 30G/ GLE 3.0 ', 'HPU-2585', 1995, '2019-05-08 17:46:42', NULL),
(15, 15, 'Carro', 'Porsche', '718 Boxster S 2.5 35', 'NAF-2036', 2016, '2019-05-08 17:47:14', NULL),
(16, 16, 'Carro', 'Porsche', 'Boxster Tiptronic', 'KHV-4964', 1997, '2019-05-08 17:47:45', NULL),
(17, 17, 'Carro', 'Renault', 'Clio Sed. Hi-Flex/Ex', 'ISQ-1393', 2005, '2019-05-08 17:48:31', NULL),
(18, 18, 'Carro', 'Renault', 'DUSTER OROCH Exp. 1.', 'KDV-8148', 2016, '2019-05-08 17:48:52', NULL),
(19, 19, 'Carro', 'Renault', 'Master 2.8 DTI Chass', 'HZV-3063', 2003, '2019-05-08 17:49:16', NULL),
(20, 20, 'Carro', 'Toyota', 'Corolla WG', 'HZI-9917', 1993, '2019-05-08 17:49:48', NULL);

--
-- Acionadores `mec_tb_veiculos`
--
DELIMITER $$
CREATE TRIGGER `mec_TG_dataVec` BEFORE INSERT ON `mec_tb_veiculos` FOR EACH ROW SET NEW.Vec_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mec_tb_vendas`
--

CREATE TABLE `mec_tb_vendas` (
  `Venda_in_codigo` int(11) NOT NULL,
  `pes_in_codigo` int(11) DEFAULT NULL,
  `Venda_bool_parcela` varchar(20) DEFAULT NULL,
  `Venda_int_qtdeParcela` int(11) DEFAULT NULL,
  `Venda_date_data` date DEFAULT NULL,
  `Venda_re_valorTotal` double(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mec_tb_vendas`
--

INSERT INTO `mec_tb_vendas` (`Venda_in_codigo`, `pes_in_codigo`, `Venda_bool_parcela`, `Venda_int_qtdeParcela`, `Venda_date_data`, `Venda_re_valorTotal`) VALUES
(1, 1, 'A Vista', 0, '2019-05-08', 127.30),
(2, 9, 'A Vista', 0, '2019-05-08', 495.50);

--
-- Acionadores `mec_tb_vendas`
--
DELIMITER $$
CREATE TRIGGER `mec_tg_dataVen` BEFORE INSERT ON `mec_tb_vendas` FOR EACH ROW SET NEW.Venda_date_data= NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_avalia`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_avalia` (
`av_in_codigo` int(11)
,`usu_in_codigo` int(11)
,`usu_st_login` varchar(100)
,`av_st_assunto` varchar(200)
,`av_st_comentario` varchar(200)
,`av_in_qntEstrela` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_cliente`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_cliente` (
`Pes_in_codigo` int(11)
,`Pes_st_tipo` varchar(60)
,`Pes_st_Nome` varchar(200)
,`Pes_in_cpf` varchar(50)
,`Pes_st_sexo` varchar(10)
,`Pes_st_bairro` varchar(30)
,`Pes_st_rua` varchar(60)
,`Pes_in_numero` varchar(35)
,`Pes_st_complemento` varchar(60)
,`Pes_st_cidade` varchar(30)
,`Pes_st_uf` varchar(10)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_contaspagar`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_contaspagar` (
`Pes_st_Nome` varchar(200)
,`ContaP_date_dataVenc` date
,`ContaP_re_totalPag` double(10,2)
,`ContaP_st_formaPag` varchar(20)
,`ItemParc_in_codigo` int(11)
,`ItemParc_in_numeroParc` int(11)
,`ItemParc_re_Valor` double(10,2)
,`ItemParc_date_dataVenc` date
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_contato`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_contato` (
`Pes_st_Nome` varchar(200)
,`cont_in_tel` varchar(20)
,`cont_in_cel` varchar(20)
,`cont_st_email` varchar(20)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_itens`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_itens` (
`Item_int_codigo` int(11)
,`Venda_in_codigo` int(11)
,`prod_in_codigo` int(11)
,`prod_st_nome` varchar(50)
,`prod_re_ValorVenda` double(10,2)
,`Item_int_qtde` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_movimenta`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_movimenta` (
`Mov_in_codigo` int(10)
,`Prod_in_codigo` int(11)
,`prod_st_nome` varchar(50)
,`prod_st_marca` varchar(200)
,`Mov_st_Tipo` varchar(25)
,`Mov_in_QtdeAtual` int(11)
,`Mov_in_QtdeAnterior` int(11)
,`Mov_in_QtdeNova` int(11)
,`Mov_date_data` date
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_upload`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_upload` (
`Pes_in_codigo` int(11)
,`usu_in_codigo` int(11)
,`img_in_codigo` int(11)
,`Pes_st_nomefantasia` varchar(60)
,`Pes_st_cidade` varchar(30)
,`Pes_st_uf` varchar(10)
,`Pes_st_bairro` varchar(30)
,`Pes_st_rua` varchar(60)
,`Pes_in_numero` varchar(35)
,`Pes_st_complemento` varchar(60)
,`img_st_imagem` varchar(60)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `mec_vw_veiculos`
-- (See below for the actual view)
--
CREATE TABLE `mec_vw_veiculos` (
`Vec_in_codigo` int(11)
,`Pes_in_codigo` int(11)
,`Pes_st_Nome` varchar(200)
,`Pes_in_cpf` varchar(50)
,`Vec_st_tipo` varchar(30)
,`Vec_st_marca` varchar(20)
,`Vec_st_modelo` varchar(20)
,`Vec_st_placa` varchar(10)
,`Vec_in_ano` int(11)
,`Vec_st_foto` varchar(1000)
);

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_avalia`
--
DROP TABLE IF EXISTS `mec_vw_avalia`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_avalia`  AS  select `a`.`av_in_codigo` AS `av_in_codigo`,`u`.`usu_in_codigo` AS `usu_in_codigo`,`u`.`usu_st_login` AS `usu_st_login`,`a`.`av_st_assunto` AS `av_st_assunto`,`a`.`av_st_comentario` AS `av_st_comentario`,`a`.`av_in_qntEstrela` AS `av_in_qntEstrela` from (`mec_tb_usuario` `u` join `mec_tb_avalia` `a` on((`u`.`usu_in_codigo` = `a`.`usu_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_cliente`
--
DROP TABLE IF EXISTS `mec_vw_cliente`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_cliente`  AS  select `mec_tb_pessoas`.`Pes_in_codigo` AS `Pes_in_codigo`,`mec_tb_pessoas`.`Pes_st_tipo` AS `Pes_st_tipo`,`mec_tb_pessoas`.`Pes_st_Nome` AS `Pes_st_Nome`,`mec_tb_pessoas`.`Pes_in_cpf` AS `Pes_in_cpf`,`mec_tb_pessoas`.`Pes_st_sexo` AS `Pes_st_sexo`,`mec_tb_pessoas`.`Pes_st_bairro` AS `Pes_st_bairro`,`mec_tb_pessoas`.`Pes_st_rua` AS `Pes_st_rua`,`mec_tb_pessoas`.`Pes_in_numero` AS `Pes_in_numero`,`mec_tb_pessoas`.`Pes_st_complemento` AS `Pes_st_complemento`,`mec_tb_pessoas`.`Pes_st_cidade` AS `Pes_st_cidade`,`mec_tb_pessoas`.`Pes_st_uf` AS `Pes_st_uf` from `mec_tb_pessoas` ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_contaspagar`
--
DROP TABLE IF EXISTS `mec_vw_contaspagar`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_contaspagar`  AS  select `p`.`Pes_st_Nome` AS `Pes_st_Nome`,`c`.`ContaP_date_dataVenc` AS `ContaP_date_dataVenc`,`c`.`ContaP_re_totalPag` AS `ContaP_re_totalPag`,`c`.`ContaP_st_formaPag` AS `ContaP_st_formaPag`,`i`.`ItemParc_in_codigo` AS `ItemParc_in_codigo`,`i`.`ItemParc_in_numeroParc` AS `ItemParc_in_numeroParc`,`i`.`ItemParc_re_Valor` AS `ItemParc_re_Valor`,`i`.`ItemParc_date_dataVenc` AS `ItemParc_date_dataVenc` from ((`mec_tb_pessoas` `p` join `mec_tb_contaspagar` `c` on((`p`.`Pes_in_codigo` = `c`.`pes_in_codigo`))) join `mec_tb_itemparcela` `i` on((`c`.`ContaP_in_codigo` = `i`.`ContaP_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_contato`
--
DROP TABLE IF EXISTS `mec_vw_contato`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_contato`  AS  select `p`.`Pes_st_Nome` AS `Pes_st_Nome`,`c`.`cont_in_tel` AS `cont_in_tel`,`c`.`cont_in_cel` AS `cont_in_cel`,`c`.`cont_st_email` AS `cont_st_email` from (`mec_tb_pessoas` `p` join `mec_tb_contato` `c` on((`p`.`Pes_in_codigo` = `c`.`pes_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_itens`
--
DROP TABLE IF EXISTS `mec_vw_itens`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_itens`  AS  select `i`.`Item_int_codigo` AS `Item_int_codigo`,`v`.`Venda_in_codigo` AS `Venda_in_codigo`,`p`.`prod_in_codigo` AS `prod_in_codigo`,`p`.`prod_st_nome` AS `prod_st_nome`,`p`.`prod_re_valorvenda` AS `prod_re_ValorVenda`,`i`.`Item_int_qtde` AS `Item_int_qtde` from ((`mec_tb_vendas` `v` join `mec_tb_itemven` `i` on((`v`.`Venda_in_codigo` = `i`.`Venda_in_codigo`))) join `mec_tb_produtos` `p` on((`i`.`Prod_in_codigo` = `p`.`prod_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_movimenta`
--
DROP TABLE IF EXISTS `mec_vw_movimenta`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_movimenta`  AS  select `m`.`Mov_in_codigo` AS `Mov_in_codigo`,`p`.`prod_in_codigo` AS `Prod_in_codigo`,`p`.`prod_st_nome` AS `prod_st_nome`,`p`.`prod_st_marca` AS `prod_st_marca`,`m`.`Mov_st_Tipo` AS `Mov_st_Tipo`,`m`.`Mov_in_QtdeAtual` AS `Mov_in_QtdeAtual`,`m`.`Mov_in_QtdeAnterior` AS `Mov_in_QtdeAnterior`,`m`.`Mov_in_QtdeNova` AS `Mov_in_QtdeNova`,`m`.`Mov_date_data` AS `Mov_date_data` from (`mec_tb_movimenta` `m` join `mec_tb_produtos` `p` on((`p`.`prod_in_codigo` = `m`.`Prod_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_upload`
--
DROP TABLE IF EXISTS `mec_vw_upload`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_upload`  AS  select `p`.`Pes_in_codigo` AS `Pes_in_codigo`,`u`.`usu_in_codigo` AS `usu_in_codigo`,`i`.`img_in_codigo` AS `img_in_codigo`,`p`.`Pes_st_nomefantasia` AS `Pes_st_nomefantasia`,`p`.`Pes_st_cidade` AS `Pes_st_cidade`,`p`.`Pes_st_uf` AS `Pes_st_uf`,`p`.`Pes_st_bairro` AS `Pes_st_bairro`,`p`.`Pes_st_rua` AS `Pes_st_rua`,`p`.`Pes_in_numero` AS `Pes_in_numero`,`p`.`Pes_st_complemento` AS `Pes_st_complemento`,`i`.`img_st_imagem` AS `img_st_imagem` from ((`mec_tb_pessoas` `p` join `mec_tb_usuario` `u` on((`u`.`usu_in_codigo` = `p`.`usu_in_codigo`))) join `mec_tb_imagens` `i` on((`u`.`usu_in_codigo` = `i`.`usu_in_codigo`))) ;

-- --------------------------------------------------------

--
-- Structure for view `mec_vw_veiculos`
--
DROP TABLE IF EXISTS `mec_vw_veiculos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mec_vw_veiculos`  AS  select `v`.`vec_in_codigo` AS `Vec_in_codigo`,`p`.`Pes_in_codigo` AS `Pes_in_codigo`,`p`.`Pes_st_Nome` AS `Pes_st_Nome`,`p`.`Pes_in_cpf` AS `Pes_in_cpf`,`v`.`Vec_st_tipo` AS `Vec_st_tipo`,`v`.`Vec_st_marca` AS `Vec_st_marca`,`v`.`Vec_st_modelo` AS `Vec_st_modelo`,`v`.`Vec_st_placa` AS `Vec_st_placa`,`v`.`Vec_in_ano` AS `Vec_in_ano`,`v`.`Vec_st_foto` AS `Vec_st_foto` from (`mec_tb_pessoas` `p` join `mec_tb_veiculos` `v` on((`p`.`Pes_in_codigo` = `v`.`Pes_in_codigo`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mec_tb_agenda`
--
ALTER TABLE `mec_tb_agenda`
  ADD PRIMARY KEY (`agen_in_codigo`),
  ADD KEY `usu_in_codigo` (`usu_in_codigo`);

--
-- Indexes for table `mec_tb_avalia`
--
ALTER TABLE `mec_tb_avalia`
  ADD PRIMARY KEY (`av_in_codigo`),
  ADD KEY `usu_in_codigo` (`usu_in_codigo`);

--
-- Indexes for table `mec_tb_contaspagar`
--
ALTER TABLE `mec_tb_contaspagar`
  ADD PRIMARY KEY (`ContaP_in_codigo`),
  ADD KEY `fk_contPess` (`pes_in_codigo`);

--
-- Indexes for table `mec_tb_contasreceber`
--
ALTER TABLE `mec_tb_contasreceber`
  ADD PRIMARY KEY (`ContaR_in_codigo`),
  ADD KEY `fk_contVen` (`venda_in_codigo`);

--
-- Indexes for table `mec_tb_contato`
--
ALTER TABLE `mec_tb_contato`
  ADD PRIMARY KEY (`cont_in_codigo`),
  ADD KEY `fk_pesCont` (`pes_in_codigo`);

--
-- Indexes for table `mec_tb_imagens`
--
ALTER TABLE `mec_tb_imagens`
  ADD PRIMARY KEY (`img_in_codigo`),
  ADD KEY `usu_in_codigo` (`usu_in_codigo`);

--
-- Indexes for table `mec_tb_itemparcela`
--
ALTER TABLE `mec_tb_itemparcela`
  ADD PRIMARY KEY (`ItemParc_in_codigo`),
  ADD KEY `fk_iteVen` (`Venda_in_codigo`),
  ADD KEY `fk_iteContP` (`ContaP_in_codigo`);

--
-- Indexes for table `mec_tb_itemven`
--
ALTER TABLE `mec_tb_itemven`
  ADD PRIMARY KEY (`Item_int_codigo`),
  ADD KEY `venda_in_codigo` (`Venda_in_codigo`),
  ADD KEY `Prod_in_codigo` (`Prod_in_codigo`);

--
-- Indexes for table `mec_tb_movimenta`
--
ALTER TABLE `mec_tb_movimenta`
  ADD PRIMARY KEY (`Mov_in_codigo`),
  ADD KEY `Prod_in_codigo` (`Prod_in_codigo`);

--
-- Indexes for table `mec_tb_pessoas`
--
ALTER TABLE `mec_tb_pessoas`
  ADD PRIMARY KEY (`Pes_in_codigo`),
  ADD KEY `fk_pessoa` (`usu_in_codigo`);

--
-- Indexes for table `mec_tb_produtos`
--
ALTER TABLE `mec_tb_produtos`
  ADD PRIMARY KEY (`prod_in_codigo`),
  ADD KEY `fk_prodPess` (`pes_in_codigo`);

--
-- Indexes for table `mec_tb_relatorio`
--
ALTER TABLE `mec_tb_relatorio`
  ADD PRIMARY KEY (`rel_in_codigo`),
  ADD KEY `fk_servico` (`serv_in_codigo`);

--
-- Indexes for table `mec_tb_servicos`
--
ALTER TABLE `mec_tb_servicos`
  ADD PRIMARY KEY (`serv_in_codigo`),
  ADD KEY `venda_in_codigo` (`venda_in_codigo`),
  ADD KEY `fk_pessoas` (`pes_in_codigo`),
  ADD KEY `fk_serVeic` (`vec_in_codigo`);

--
-- Indexes for table `mec_tb_usuario`
--
ALTER TABLE `mec_tb_usuario`
  ADD PRIMARY KEY (`usu_in_codigo`);

--
-- Indexes for table `mec_tb_veiculos`
--
ALTER TABLE `mec_tb_veiculos`
  ADD PRIMARY KEY (`vec_in_codigo`),
  ADD KEY `fk_pesVeic` (`Pes_in_codigo`);

--
-- Indexes for table `mec_tb_vendas`
--
ALTER TABLE `mec_tb_vendas`
  ADD PRIMARY KEY (`Venda_in_codigo`),
  ADD KEY `fk_pesVen` (`pes_in_codigo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `mec_tb_agenda`
--
ALTER TABLE `mec_tb_agenda`
  MODIFY `agen_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `mec_tb_avalia`
--
ALTER TABLE `mec_tb_avalia`
  MODIFY `av_in_codigo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mec_tb_contaspagar`
--
ALTER TABLE `mec_tb_contaspagar`
  MODIFY `ContaP_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `mec_tb_contasreceber`
--
ALTER TABLE `mec_tb_contasreceber`
  MODIFY `ContaR_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `mec_tb_contato`
--
ALTER TABLE `mec_tb_contato`
  MODIFY `cont_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `mec_tb_imagens`
--
ALTER TABLE `mec_tb_imagens`
  MODIFY `img_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `mec_tb_itemparcela`
--
ALTER TABLE `mec_tb_itemparcela`
  MODIFY `ItemParc_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `mec_tb_itemven`
--
ALTER TABLE `mec_tb_itemven`
  MODIFY `Item_int_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `mec_tb_movimenta`
--
ALTER TABLE `mec_tb_movimenta`
  MODIFY `Mov_in_codigo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `mec_tb_pessoas`
--
ALTER TABLE `mec_tb_pessoas`
  MODIFY `Pes_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `mec_tb_produtos`
--
ALTER TABLE `mec_tb_produtos`
  MODIFY `prod_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `mec_tb_relatorio`
--
ALTER TABLE `mec_tb_relatorio`
  MODIFY `rel_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `mec_tb_servicos`
--
ALTER TABLE `mec_tb_servicos`
  MODIFY `serv_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `mec_tb_usuario`
--
ALTER TABLE `mec_tb_usuario`
  MODIFY `usu_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `mec_tb_veiculos`
--
ALTER TABLE `mec_tb_veiculos`
  MODIFY `vec_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `mec_tb_vendas`
--
ALTER TABLE `mec_tb_vendas`
  MODIFY `Venda_in_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `mec_tb_agenda`
--
ALTER TABLE `mec_tb_agenda`
  ADD CONSTRAINT `usu_in_codigo` FOREIGN KEY (`usu_in_codigo`) REFERENCES `mec_tb_usuario` (`usu_in_codigo`);

--
-- Limitadores para a tabela `mec_tb_avalia`
--
ALTER TABLE `mec_tb_avalia`
  ADD CONSTRAINT `mec_tb_avalia_ibfk_1` FOREIGN KEY (`usu_in_codigo`) REFERENCES `mec_tb_usuario` (`usu_in_codigo`);

--
-- Limitadores para a tabela `mec_tb_contaspagar`
--
ALTER TABLE `mec_tb_contaspagar`
  ADD CONSTRAINT `fk_contPess` FOREIGN KEY (`pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_contasreceber`
--
ALTER TABLE `mec_tb_contasreceber`
  ADD CONSTRAINT `fk_contVen` FOREIGN KEY (`venda_in_codigo`) REFERENCES `mec_tb_vendas` (`Venda_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_contato`
--
ALTER TABLE `mec_tb_contato`
  ADD CONSTRAINT `fk_pesCont` FOREIGN KEY (`pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_imagens`
--
ALTER TABLE `mec_tb_imagens`
  ADD CONSTRAINT `mec_tb_imagens_ibfk_1` FOREIGN KEY (`usu_in_codigo`) REFERENCES `mec_tb_usuario` (`usu_in_codigo`);

--
-- Limitadores para a tabela `mec_tb_itemparcela`
--
ALTER TABLE `mec_tb_itemparcela`
  ADD CONSTRAINT `fk_iteContP` FOREIGN KEY (`ContaP_in_codigo`) REFERENCES `mec_tb_contaspagar` (`ContaP_in_codigo`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_iteVen` FOREIGN KEY (`Venda_in_codigo`) REFERENCES `mec_tb_vendas` (`Venda_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_itemven`
--
ALTER TABLE `mec_tb_itemven`
  ADD CONSTRAINT `Prod_in_codigo` FOREIGN KEY (`Prod_in_codigo`) REFERENCES `mec_tb_produtos` (`prod_in_codigo`) ON DELETE CASCADE,
  ADD CONSTRAINT `venda_in_codigo` FOREIGN KEY (`Venda_in_codigo`) REFERENCES `mec_tb_vendas` (`Venda_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_pessoas`
--
ALTER TABLE `mec_tb_pessoas`
  ADD CONSTRAINT `fk_pessoa` FOREIGN KEY (`usu_in_codigo`) REFERENCES `mec_tb_usuario` (`usu_in_codigo`);

--
-- Limitadores para a tabela `mec_tb_produtos`
--
ALTER TABLE `mec_tb_produtos`
  ADD CONSTRAINT `fk_prodPess` FOREIGN KEY (`pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_relatorio`
--
ALTER TABLE `mec_tb_relatorio`
  ADD CONSTRAINT `fk_servico` FOREIGN KEY (`serv_in_codigo`) REFERENCES `mec_tb_servicos` (`serv_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_servicos`
--
ALTER TABLE `mec_tb_servicos`
  ADD CONSTRAINT `fk_pessoas` FOREIGN KEY (`pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_serVeic` FOREIGN KEY (`vec_in_codigo`) REFERENCES `mec_tb_veiculos` (`vec_in_codigo`) ON DELETE CASCADE,
  ADD CONSTRAINT `mec_tb_servicos_ibfk_2` FOREIGN KEY (`venda_in_codigo`) REFERENCES `mec_tb_vendas` (`Venda_in_codigo`);

--
-- Limitadores para a tabela `mec_tb_veiculos`
--
ALTER TABLE `mec_tb_veiculos`
  ADD CONSTRAINT `fk_pesVeic` FOREIGN KEY (`Pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `mec_tb_vendas`
--
ALTER TABLE `mec_tb_vendas`
  ADD CONSTRAINT `fk_pesVen` FOREIGN KEY (`pes_in_codigo`) REFERENCES `mec_tb_pessoas` (`Pes_in_codigo`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
