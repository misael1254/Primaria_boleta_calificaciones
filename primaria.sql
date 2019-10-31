/*
 Navicat Premium Data Transfer

 Source Server         : Carolina's Project
 Source Server Type    : MySQL
 Source Server Version : 50524
 Source Host           : localhost:3306
 Source Schema         : primaria

 Target Server Type    : MySQL
 Target Server Version : 50524
 File Encoding         : 65001

 Date: 25/11/2018 17:50:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for alumno
-- ----------------------------
DROP TABLE IF EXISTS `alumno`;
CREATE TABLE `alumno`  (
  `curp_alumno` varchar(18) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '',
  `ap_pat_alumno` varchar(35) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ap_mat_alumno` varchar(35) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nombre_alumno` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `edad_alumno` int(2) NOT NULL,
  `fecha_nacimiento_alumno` date NOT NULL,
  `sexo_alumno` char(1) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `tipo_sangre` varchar(3) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `enfer_alergi` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `curp_tutor` varchar(18) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `grado_grupo` char(1) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`curp_alumno`) USING BTREE,
  INDEX `alumno_ibfk_1`(`curp_tutor`) USING BTREE,
  INDEX `alumno_ibfk_2`(`grado_grupo`) USING BTREE,
  CONSTRAINT `alumno_ibfk_1` FOREIGN KEY (`curp_tutor`) REFERENCES `tutor` (`curp_tutor`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `alumno_ibfk_2` FOREIGN KEY (`grado_grupo`) REFERENCES `grupo` (`grado_grupo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of alumno
-- ----------------------------
INSERT INTO `alumno` VALUES ('AADR110705MGRLLS09', 'Alcañiz', 'Del Rio', 'Rosa', 7, '2011-07-05', 'M', 'O*', 'NINGUNA', 'JIAA840715MGRIRN01', '2');
INSERT INTO `alumno` VALUES ('AANJ120504MGRRVS06', 'Arango', 'Navalon', 'Josefa', 6, '2012-05-04', 'M', 'O+', 'Inicios de gastritis.', 'MORA831008MGRRQN01', '1');
INSERT INTO `alumno` VALUES ('AAPY101014MGRYZL02', 'Ayala', 'Paez', 'Yolanda', 8, '2010-10-14', 'M', 'O+', 'NINGUNA', 'AAFA861006HGRYRL05', '3');
INSERT INTO `alumno` VALUES ('AEAA070610MGRLM01', 'Almendros', 'Amigo', 'Aurora', 11, '2007-06-10', 'M', 'O+', 'NINGUNA', 'AOZA810101HGRZMI04', '6');
INSERT INTO `alumno` VALUES ('AIBM111111MGRTRR01', 'Atienza', 'Bernat', 'Maria Mercedes', 7, '2011-11-11', 'M', 'O+', 'NINGUNA', 'GUBM831214MGRRZR03', '2');
INSERT INTO `alumno` VALUES ('AUTM070625MGRGRI02', 'Aguilo', 'Torrente', 'Miriam', 11, '2007-06-25', 'M', 'O+', 'NINGUNA', 'TEMJ210206HGRRLN07', '6');
INSERT INTO `alumno` VALUES ('BACC100406HGRRMR01', 'Barquero', 'Camarero', 'Cristobal', 8, '2010-04-06', 'H', 'B+', 'NINGUNA', 'TOLA840804MGRRMN03', '3');
INSERT INTO `alumno` VALUES ('BAMV070801MGRSDI02', 'Bas', 'Madrid', 'Victor Manuel', 11, '2007-08-01', 'H', 'A+', 'NINGUNA', 'VESG810103HGRLRN04', '6');
INSERT INTO `alumno` VALUES ('BASV080727HGRRII00', 'Barros', 'Simo', 'Victor', 10, '2008-07-27', 'H', 'O+', 'Miopia', 'EEVV811009HGRCII04', '5');
INSERT INTO `alumno` VALUES ('BAVC120105HGRRZS08', 'Barrientos', 'Vazquez', 'Cesar', 6, '2012-01-05', 'H', 'A+', 'NINGUNA', 'GIPJ820207HGRRII01', '1');
INSERT INTO `alumno` VALUES ('BINT091208MGRRVR01', 'Briz', 'Navarro', 'Teresa', 9, '2009-12-08', 'H', 'O-', 'Intolerante a lacteos.', 'AAFA841103MGRVIN05', '4');
INSERT INTO `alumno` VALUES ('CACI100619HGRPSS07', 'Capel', 'Cuesta', 'Ismael', 8, '2010-06-19', 'H', 'O+', 'Alergia a gatos.', 'RAGJ801009HGRBIN01', '3');
INSERT INTO `alumno` VALUES ('CAPA071107MGRSLL00', 'Castillejo', 'Palacin', 'Alvaro', 11, '2007-11-07', 'H', 'A+', 'NINGUNA', 'TEAJ800908HGRILS01', '6');
INSERT INTO `alumno` VALUES ('CAVJ120328HGRSLN01', 'Casado', 'Valle', 'Joan', 6, '2012-03-28', 'H', 'B+', 'Alegía a paracetamol.', 'PICR800907HGRILI01', '1');
INSERT INTO `alumno` VALUES ('CAVV090604MGRBI05', 'Cabrerizo', 'Vizcaino', 'Veronica', 9, '2009-06-04', 'M', 'B+', 'NINGUNA', 'BAPN850606MGRRRT08', '4');
INSERT INTO `alumno` VALUES ('CAZM100201HGRRRI09', 'Cara', 'Zarza', 'Miguel', 8, '2010-02-01', 'H', 'O+', 'NINGUNA', 'MALD831217MGRSIL00', '3');
INSERT INTO `alumno` VALUES ('COPS120108HGRNRL08', 'Concepcion', 'Peris', 'Salvador', 6, '2012-01-08', 'H', 'A+', 'Alergías a picadura de abejas/avispas.', 'COMD911107HGRNLM06', '1');
INSERT INTO `alumno` VALUES ('CUME090512HGRNM09', 'Cuenca', 'Montiel', 'Emilio', 9, '2009-05-12', 'H', 'O-', 'NINGUNA', 'VESG810103HGRLRN04', '4');
INSERT INTO `alumno` VALUES ('DEAJ091012MGRY011', 'De Los Reyes', 'Ayllon', 'Josefa', 9, '2009-10-12', 'M', 'A+', 'NINGUNA', 'TEMJ210206HGRRLN07', '4');
INSERT INTO `alumno` VALUES ('DELS080914HGRLSN00', 'Del Amo', 'Lasheras', 'Santiago', 10, '2008-09-14', 'H', 'A-', 'NINGUNA', 'AAFA841103MGRVIN05', '5');
INSERT INTO `alumno` VALUES ('DORR120303HGRPGB03', 'Dopico', 'Rego', 'Ruben', 6, '2012-03-03', 'H', 'O+', 'NINGUNA', 'RARJ340216HGRMMN01', '1');
INSERT INTO `alumno` VALUES ('DOSJ100916HGRPNV00', 'Dopico', 'Santamaria', 'Javier', 8, '2010-09-16', 'H', 'B+', 'NINGUNA', 'HECC800502HGRRDR08', '3');
INSERT INTO `alumno` VALUES ('EAVA101201HGRSIL04', 'Esparza', 'Villen', 'Albert', 8, '2010-12-01', 'H', 'AB', 'NINGUNA', 'CACP850506MGRTLL02', '3');
INSERT INTO `alumno` VALUES ('EEAA120206MGRSRN03', 'Estepa', 'Ariño', 'Antonia', 6, '2012-02-06', 'M', 'B+', 'NINGUNA', 'CEML830902HGRHRI02', '1');
INSERT INTO `alumno` VALUES ('FUTM100411MGRRLR02', 'Fuertes', 'Tolosa', 'Rosa', 8, '2010-04-11', 'M', 'B-', 'NINGUNA', 'OOAA830403MGRCGR08', '3');
INSERT INTO `alumno` VALUES ('GAEC080306MGRRSR03', 'Garcia', 'Estrella', 'Cristina', 10, '2008-03-06', 'M', 'O+', 'Miopia y astigmatismo.', 'TEAJ800908HGRILS01', '5');
INSERT INTO `alumno` VALUES ('GAGM090610MGRBBR07', 'Gabarri', 'Gabbarre', 'Maria Elena', 9, '2009-06-10', 'M', 'B+', 'NINGUNA', 'GASA861016HGRBZD01', '4');
INSERT INTO `alumno` VALUES ('GIFA100122HGRIRN05', 'Gimenez', 'Ferrer', 'Angel', 8, '2010-01-22', 'H', 'AB+', 'NINGUNA', 'EEVV811009HGRCII04', '3');
INSERT INTO `alumno` VALUES ('GOMA990222MHSMNXD0', 'Gomez', 'Muñoz', 'Ana', 7, '2007-01-01', 'M', 'O+', 'NINGUNA', 'BEMM820207HGRRII01', '2');
INSERT INTO `alumno` VALUES ('GOME970977HMSNXD04', 'Gomez', 'Martinez', 'Emanuel', 7, '2007-09-02', 'H', 'B+', 'NINGUNA', 'AAFD861204HGRRSN03', '2');
INSERT INTO `alumno` VALUES ('HEMV111106MGRRRR05', 'Hernan', 'Martinez', 'Veronica', 7, '2011-11-06', 'M', 'A-', 'NINGUNA', 'TOLA840804MGRRMN03', '2');
INSERT INTO `alumno` VALUES ('IOGV120214MGRBZL06', 'Iborra', 'Guzman', 'Valentina', 6, '2012-02-14', 'M', 'O+', 'Generación de ronchas por exposición a sol excesivo.', 'IOMC911212HGRBGL09', '1');
INSERT INTO `alumno` VALUES ('JUMM080910MGRNRI02', 'Juan', 'Morera', 'Milagros', 10, '2008-09-10', 'M', 'O+', 'NINGUNA', 'OOAA830902MGRCGR06', '5');
INSERT INTO `alumno` VALUES ('LEMS091112MGRDLN01', 'Ledo', 'Molina', 'Sandra', 9, '2009-11-12', 'M', 'O+', 'NINGUNA', 'RAGJ801009HGRBIN01', '4');
INSERT INTO `alumno` VALUES ('LODJ120306HGRRLN04', 'Lorenzo', 'Del Aguila', 'Juan José', 6, '2012-03-06', 'H', 'O+', 'NINGUNA', 'AAFD861204HGRRSN03', '1');
INSERT INTO `alumno` VALUES ('MABA100205MGRTNN09', 'Matesanz', 'Benitez', 'Andrea', 8, '2010-02-05', 'M', 'A+', 'NINGUNA', 'CACP850506MGRTLL02', '3');
INSERT INTO `alumno` VALUES ('MACY070923MGRSV09', 'Cuevas', 'Mascaro', 'Yolanda', 11, '2007-09-23', 'M', 'O+', 'NINGUNA', 'HECC800502HGRRDR08', '6');
INSERT INTO `alumno` VALUES ('MAMG080209MGRNL09', 'Maestre', 'Mancera', 'Gloria', 10, '2008-02-09', 'M', 'O+', 'NINGUNA', 'MAPJ910502HGRSRS04', '5');
INSERT INTO `alumno` VALUES ('MICN081027HGRII02', 'Mira', 'Cañada', 'Nicolas', 10, '2008-10-27', 'H', 'B+', 'NINGUNA', 'BEMM820207HGRRII01', '5');
INSERT INTO `alumno` VALUES ('MOLA110703HGRZRN06', 'Mozo', 'Lora', 'Angel', 7, '2011-07-03', 'H', 'O-', 'NINGUNA', 'CALJ840302MGRLYS01', '2');
INSERT INTO `alumno` VALUES ('MOPL110522MGRNRC08', 'Monzon', 'Prat', 'Lucia', 7, '2011-05-22', 'M', 'A+', 'Alergia por exceso de polvo.', 'CACP850506MGRTLL02', '2');
INSERT INTO `alumno` VALUES ('MOSF070804MGRRIR06', 'Morales', 'Silva', 'Fernando', 11, '2007-08-04', 'H', 'O+', 'NINGUNA', 'OOAA830403MGRCGR08', '6');
INSERT INTO `alumno` VALUES ('NIAA111106HGRIGL09', 'Niño', 'Aguera', 'Alejandro', 7, '2011-11-06', 'H', 'O+', 'Alergia al paracetamol.', 'BAPN850606MGRRRT08', '2');
INSERT INTO `alumno` VALUES ('PACL080524MGRLBR03', 'Palau', 'Cabrerizo', 'Laura', 10, '2008-05-24', 'M', 'O+', 'Sintomas principales de gastritis', 'RARJ340216HGRMMN01', '5');
INSERT INTO `alumno` VALUES ('PAML071211MGRLLI06', 'Plaza', 'Melgar', 'Luis', 11, '2007-12-11', 'H', 'A+', 'Intoletante a lacteos.', 'EILA611001HGRSRN06', '6');
INSERT INTO `alumno` VALUES ('PAPJ120427HGRJYN07', 'Pajuelo', 'Paya', 'Juan Antonio', 6, '2012-04-27', 'H', 'O+', 'Toxoplasmosis', 'BAAC801009HGRLLR06', '1');
INSERT INTO `alumno` VALUES ('PECC080802MGRDRN06', 'Pedreira', 'Carcero', 'Consuelo', 10, '2008-08-02', 'M', 'O+', 'NINGUNA', 'PICR800907HGRILI01', '5');
INSERT INTO `alumno` VALUES ('PIJE100815HGRIZM05', 'Pinto', 'Juez', 'Emilio', 8, '2010-08-15', 'H', 'O-', 'NINGUNA', 'PISP860713HGRIBD09', '3');
INSERT INTO `alumno` VALUES ('POCJ090415HGRSSS06', 'Pons', 'Cascales', 'Jose Miguel', 9, '2009-04-15', 'H', 'O+', 'NINGUNA', 'CEML830902HGRHRI02', '4');
INSERT INTO `alumno` VALUES ('RABP110815HGRYRB06', 'Raya', 'Bernandez', 'Pablo', 7, '2011-08-15', 'H', 'B+', 'NINGUNA', 'HECC800502HGRRDR08', '2');
INSERT INTO `alumno` VALUES ('REMS110921HGRGNL02', 'Regueira', 'Montero', 'Salvador', 7, '2011-09-21', 'H', 'B+', 'NINGUNA', 'REME860702HGRGLD01', '2');
INSERT INTO `alumno` VALUES ('ROPJ070210MGRR09', 'Rosado', 'Portilla', 'Juana', 11, '2007-02-10', 'M', 'O+', 'Alergia al polvo excesivo.', 'RAGJ801009HGRBIN01', '6');
INSERT INTO `alumno` VALUES ('SAOC080925MGRLLR09', 'Saldaña', 'Olivan', 'Cristina', 10, '2008-09-25', 'M', 'O+', 'NINGUNA', 'DONJ770907HGRBDN00', '5');
INSERT INTO `alumno` VALUES ('SAPJ090618HGRLLS05', 'Sala', 'Pallares', 'Jose Carlos', 9, '2009-06-18', 'H', 'B+', 'Problemas auditivos.', 'AAFA841103MGRVIN05', '4');
INSERT INTO `alumno` VALUES ('SAVE110913MGRMR011', 'Sampedro', 'Verde', 'Eva', 7, '2011-09-13', 'M', 'B+', 'NINGUNA', 'MALD831217MGRSIL00', '2');
INSERT INTO `alumno` VALUES ('SIBB110604MGRIRT02', 'Sicilia', 'Barco', 'Beatriz', 7, '2011-06-04', 'M', 'O-', 'NINGUNA', 'NEMM830407MGRVNR01', '2');
INSERT INTO `alumno` VALUES ('TOLR120510HGRRLF02', 'Torrent', 'Llunch', 'Rafael', 6, '2012-05-10', 'H', 'O-', 'NINGUNA', 'DONJ770907HGRBDN00', '1');
INSERT INTO `alumno` VALUES ('UIMC091209HGRRR03', 'Urbina', 'Malagon', 'Carlos', 9, '2009-12-09', 'H', 'A+', 'NINGUNA', 'UIDL910205HGRRLS04', '4');
INSERT INTO `alumno` VALUES ('UURM120314HGRRMS18', 'Urzua', 'Ramos', 'Misael', 6, '2012-03-14', 'H', 'o+', 'ninguna', 'UURM970314HGRRMS18', '4');
INSERT INTO `alumno` VALUES ('VALL090228HGRLSR07', 'Valcarcel', 'Laso', 'Lorenzo', 9, '2009-02-28', 'H', 'A+', 'NINGUNA', 'MALD831217MGRSIL00', '4');
INSERT INTO `alumno` VALUES ('VESJ080816HGR02', 'Velarde', 'Saucedo', 'Josep', 10, '2008-08-16', 'H', 'A+', 'NINGUNA', 'BAAC801009HGRLLR06', '5');
INSERT INTO `alumno` VALUES ('YEEM070603MGRPSR03', 'Yepes', 'Espin', 'Marco', 11, '2007-06-03', 'H', 'A-', 'NINGUNA', 'BAFM810304HGRRJR08', '6');

-- ----------------------------
-- Table structure for bitacora
-- ----------------------------
DROP TABLE IF EXISTS `bitacora`;
CREATE TABLE `bitacora`  (
  `usuario` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `entrada` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `salida` varchar(40) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of bitacora
-- ----------------------------
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:11:05', '2018-10-15 09:11:29');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:12:30', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:20:49', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:26:42', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:38:05', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:44:32', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:51:55', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:54:26', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:55:54', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-15 09:56:59', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:33:04', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:36:59', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:40:47', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:45:36', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:47:20', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:51:15', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:52:31', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 09:56:11', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:01:59', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:02:54', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:05:04', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:06:08', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:18:02', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:20:11', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:21:38', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:23:41', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:25:34', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 10:27:43', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:21:33', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:24:51', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:33:06', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:36:40', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:44:42', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 11:57:00', '2018-10-16 11:57:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 13:18:57', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 13:25:31', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-16 13:36:57', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:24:37', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:36:13', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:37:06', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:40:13', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:40:50', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:47:22', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:54:44', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 08:55:27', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:00:07', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:08:25', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:10:02', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:15:46', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:22:36', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 09:24:10', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 10:44:57', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 10:46:30', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:26:24', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:31:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:33:26', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:36:48', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:38:28', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:39:59', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:41:18', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:43:56', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:44:55', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:46:07', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:47:38', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:49:19', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:50:14', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:51:42', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:52:41', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 12:58:34', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:00:06', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:01:10', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:02:11', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:09:28', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:10:34', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:11:20', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:12:28', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:13:16', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:14:56', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:16:15', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:17:11', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:25:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:29:17', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:30:51', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:34:25', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:36:44', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:40:56', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:42:58', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:44:42', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:45:56', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:47:14', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:48:02', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:48:51', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:50:02', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 13:52:39', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 19:17:19', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 19:21:45', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 20:25:26', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 20:28:11', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 20:29:59', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 20:32:00', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 20:47:07', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 21:01:09', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 21:11:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 22:57:31', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 22:59:57', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 23:06:09', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-17 23:07:26', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 00:52:53', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 00:55:46', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 00:57:31', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 00:59:55', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:01:31', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:03:04', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:05:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:07:42', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:08:55', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:10:17', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:11:28', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:12:46', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:13:57', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 01:15:36', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 10:42:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 10:43:37', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 10:52:03', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 10:58:09', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 11:53:14', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 11:53:51', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:00:32', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:03:40', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:15:05', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:19:47', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:22:22', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:23:30', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:25:34', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 12:41:07', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 13:59:06', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 17:55:58', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 18:38:58', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:22:45', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:25:18', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:26:58', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:29:33', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:33:12', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:37:02', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:39:41', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:47:07', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:49:55', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:51:46', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 19:53:11', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:32:25', '2018-10-18 20:33:16');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:38:42', '2018-10-18 20:58:47');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:47:08', '2018-10-18 20:58:47');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:50:06', '2018-10-18 20:58:47');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:57:32', '2018-10-18 20:58:47');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:58:38', '2018-10-18 20:58:47');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 20:59:30', '2018-10-18 20:59:46');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:08:05', '2018-10-18 21:08:31');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:10:02', '2018-10-18 21:21:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:16:56', '2018-10-18 21:21:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:20:54', '2018-10-18 21:21:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:21:52', '2018-10-18 21:22:36');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:24:36', '2018-10-18 21:24:54');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:25:38', '2018-10-18 21:25:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:31:38', '2018-10-18 21:31:49');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 21:32:00', '2018-10-18 21:32:27');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 22:26:37', '2018-10-18 23:08:59');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:05:22', '2018-10-18 23:08:59');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:08:17', '2018-10-18 23:08:59');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:09:27', '2018-10-18 23:10:05');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:18:17', '2018-10-18 23:19:24');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:42:55', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:44:44', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:47:47', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:50:09', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:51:22', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:52:52', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:55:14', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-18 23:58:37', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:01:41', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:02:33', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:03:42', '2018-10-19 00:04:13');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:09:20', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:11:04', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:11:56', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:12:45', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:14:54', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:16:48', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:17:54', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:19:10', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:31:44', '2018-10-19 00:32:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:33:35', '2018-10-19 00:34:20');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:36:32', '2018-10-19 00:37:43');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 00:47:16', '2018-10-19 00:47:31');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:25:30', '2018-10-19 07:32:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:28:21', '2018-10-19 07:32:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:33:34', '2018-10-19 07:33:56');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:36:39', '2018-10-19 07:38:28');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:38:10', '2018-10-19 07:38:28');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:38:59', '2018-10-19 07:39:27');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:41:03', '2018-10-19 07:43:10');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:46:12', '2018-10-19 07:48:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:49:38', '2018-10-19 07:51:43');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-19 07:52:21', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 19:49:39', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 19:56:24', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:02:27', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:06:53', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:08:07', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:10:28', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:11:09', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:12:54', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:17:23', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:20:07', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 20:28:51', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 23:11:29', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-21 23:23:32', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 00:33:52', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:18:36', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:21:26', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:23:55', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:26:42', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:28:42', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:45:26', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:58:39', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 13:59:47', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:00:25', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:02:37', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:03:02', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:03:54', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:04:42', '2018-10-22 14:05:22');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:07:49', '2018-10-22 14:09:57');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:10:35', '2018-10-22 14:18:20');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:13:21', '2018-10-22 14:18:20');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:15:29', '2018-10-22 14:18:20');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 14:18:50', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 17:43:04', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 17:45:58', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 17:53:43', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 17:56:40', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 18:59:54', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:05:45', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:07:21', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:15:05', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:17:09', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:20:10', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:27:57', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:35:52', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:54:06', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 19:55:44', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:01:20', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:08:15', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:10:08', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:19:12', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:24:57', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:25:52', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:28:22', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:31:45', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-22 20:36:04', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 09:23:40', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 10:37:56', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 10:39:52', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 10:44:19', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 10:46:06', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 13:54:49', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 13:57:43', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 13:58:02', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-23 13:58:52', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 10:51:37', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 11:59:30', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:08:54', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:34:25', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:37:40', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:38:46', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:40:29', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:41:50', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 12:45:17', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:19:42', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:27:05', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:48:42', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:51:15', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:54:47', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:57:55', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 13:58:24', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:00:53', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:02:23', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:04:28', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:19:02', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:25:51', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:44:35', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 14:45:54', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 17:52:26', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 17:53:39', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 17:54:44', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 17:55:40', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:09:36', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:18:36', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:19:57', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:20:59', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:23:40', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:25:28', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:26:39', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:30:13', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 18:40:41', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 20:47:23', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 20:51:00', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:00:00', '2018-10-24 21:00:04');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:00:41', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:01:11', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:02:48', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:03:47', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:15:16', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:16:48', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:17:30', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:18:38', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:19:39', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:29:13', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:30:50', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:31:24', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:36:04', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-24 21:41:58', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 07:54:01', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 07:59:18', '2018-10-25 08:01:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:02:27', '2018-10-25 08:02:42');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:07:17', '2018-10-25 08:07:51');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:08:34', '2018-10-25 08:11:42');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:13:12', '2018-10-25 08:22:24');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:15:26', '2018-10-25 08:22:24');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:20:16', '2018-10-25 08:22:24');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:33:16', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 08:34:12', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 10:26:12', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 10:28:55', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 10:30:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 10:31:28', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 10:38:34', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:14:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:15:40', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:30:55', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:31:08', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:33:51', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:34:41', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:38:15', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:41:48', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:45:05', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:46:31', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:48:58', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:51:52', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:52:37', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:53:11', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:55:42', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 12:59:51', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:03:32', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:08:21', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:09:22', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:10:12', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:31:57', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:32:12', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:33:33', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:34:32', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-25 13:53:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:38:44', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:40:37', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:41:23', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:43:24', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:49:10', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:49:27', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:58:09', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 09:59:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 10:06:59', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 10:13:30', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 10:59:49', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:15:56', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:16:17', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:17:43', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:24:01', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:31:23', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:50:20', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 12:54:31', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 14:37:46', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 14:38:48', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-10-26 14:59:01', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-07 21:57:41', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-07 21:59:09', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-07 22:47:40', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-07 23:04:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-07 23:13:04', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-08 10:06:58', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-08 11:55:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 09:55:33', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 10:07:37', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 10:30:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 11:04:28', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 13:09:25', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 13:18:55', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 13:38:06', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 13:38:54', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 13:41:16', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 15:50:27', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 16:43:32', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 17:06:28', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 17:16:25', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 18:59:12', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 19:08:07', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 19:17:42', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 19:20:19', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 19:37:35', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 19:50:56', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:06:33', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:07:36', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:13:00', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:14:58', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:53:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 20:59:42', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 21:01:36', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-09 21:06:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 09:48:59', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 10:39:09', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 11:58:41', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 12:13:04', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 13:24:44', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 13:36:57', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 13:40:24', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 13:50:51', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 14:04:50', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 14:25:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 18:16:09', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 18:18:36', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 18:31:56', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 19:42:43', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 19:55:05', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 20:34:15', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 21:07:55', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 21:26:26', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 21:58:18', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-14 22:08:46', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-15 09:42:37', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-16 07:20:27', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-16 07:23:14', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-16 07:32:40', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-21 08:42:27', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 08:15:41', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 08:21:07', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 08:22:22', '2018-11-22 08:38:58');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 08:39:02', '2018-11-22 08:43:29');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 09:32:03', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 09:37:46', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 09:43:21', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 09:50:38', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:05:20', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:11:25', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:18:39', '2018-11-22 10:20:45');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:21:44', '2018-11-22 10:32:55');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:22:31', '2018-11-22 10:32:55');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:26:48', '2018-11-22 10:32:55');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:30:00', '2018-11-22 10:32:55');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:34:13', '2018-11-22 10:35:01');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:44:06', '2018-11-22 10:45:49');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 10:53:58', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 11:50:34', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 11:51:08', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 11:56:04', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 11:57:09', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 11:58:40', '2018-11-22 11:59:11');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 12:02:17', '2018-11-22 12:02:42');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-22 12:07:09', '2018-11-22 12:12:53');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-25 11:31:39', '2018-11-25 17:21:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-25 17:21:14', '2018-11-25 17:21:18');
INSERT INTO `bitacora` VALUES ('edgar', '2018-11-25 17:21:27', '2018-11-25 17:21:30');

-- ----------------------------
-- Table structure for calificacion
-- ----------------------------
DROP TABLE IF EXISTS `calificacion`;
CREATE TABLE `calificacion`  (
  `calif_materia` float(3, 1) NOT NULL,
  `mes_calificacion` varchar(7) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `clave_materia` varchar(9) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `curp_alumno` varchar(18) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  INDEX `calificacion_ibfk_1`(`clave_materia`) USING BTREE,
  INDEX `calificacion_ibfk_2`(`curp_alumno`) USING BTREE,
  CONSTRAINT `calificacion_ibfk_1` FOREIGN KEY (`clave_materia`) REFERENCES `materia` (`clave_materia`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `calificacion_ibfk_2` FOREIGN KEY (`curp_alumno`) REFERENCES `alumno` (`curp_alumno`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of calificacion
-- ----------------------------
INSERT INTO `calificacion` VALUES (5.0, 'Diag', 'CIN-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Diag', 'EDA-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Diag', 'EDF-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Diag', 'EDV-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Diag', 'ESP-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Diag', 'FCE-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Diag', 'MAT-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'CIN-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'EDA-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Sept', 'EDF-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'EDV-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'ESP-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Sept', 'FCE-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'MAT-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Sept', 'CLE-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'DIS-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Sept', 'ORT-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Sept', 'TAR-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Sept', 'UYA-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'CIN-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'EDA-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'EDF-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'EDV-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'ESP-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'FCE-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'MAT-3-SEP', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'CLE-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'DIS-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'ORT-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (5.0, 'Octu', 'TAR-3-EXT', 'AAPY101014MGRYZL02');
INSERT INTO `calificacion` VALUES (6.0, 'Octu', 'UYA-3-EXT', 'AAPY101014MGRYZL02');

-- ----------------------------
-- Table structure for grupo
-- ----------------------------
DROP TABLE IF EXISTS `grupo`;
CREATE TABLE `grupo`  (
  `grado_grupo` char(1) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nombre_profesor` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`grado_grupo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of grupo
-- ----------------------------
INSERT INTO `grupo` VALUES ('1', 'Anuar Vargas Clemente');
INSERT INTO `grupo` VALUES ('2', 'Azucena Basilio Encarnación');
INSERT INTO `grupo` VALUES ('3', 'Maria Luisa Soto Olea');
INSERT INTO `grupo` VALUES ('4', 'Blanca Martinez Ochoa');
INSERT INTO `grupo` VALUES ('5', 'Francisco Salgado Delabra');
INSERT INTO `grupo` VALUES ('6', 'Jesús Ramirez Carmona');

-- ----------------------------
-- Table structure for materia
-- ----------------------------
DROP TABLE IF EXISTS `materia`;
CREATE TABLE `materia`  (
  `clave_materia` varchar(9) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nombre_materia` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `especif_materia` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `grado_grupo` char(1) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`clave_materia`) USING BTREE,
  INDEX `materia_ibfk_1`(`grado_grupo`) USING BTREE,
  CONSTRAINT `materia_ibfk_1` FOREIGN KEY (`grado_grupo`) REFERENCES `grupo` (`grado_grupo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of materia
-- ----------------------------
INSERT INTO `materia` VALUES ('CIN-3-SEP', 'CIENCIAS NATURALES 1', 'SEP', '3');
INSERT INTO `materia` VALUES ('CIN-4-SEP', 'CIENCIAS NATURALES 2', 'SEP', '4');
INSERT INTO `materia` VALUES ('CIN-5-SEP', 'CIENCIAS NATURALES 3', 'SEP', '5');
INSERT INTO `materia` VALUES ('CIN-6-SEP', 'CIENCIAS NATURALES 4', 'SEP', '6');
INSERT INTO `materia` VALUES ('CLE-1-EXT', 'COMP. LECT', 'EXT', '1');
INSERT INTO `materia` VALUES ('CLE-3-EXT', 'COMP. LECT', 'EXT', '3');
INSERT INTO `materia` VALUES ('CLE-4-EXT', 'COMP. LECT', 'EXT', '4');
INSERT INTO `materia` VALUES ('CLE-5-EXT', 'COMP. LECT', 'EXT', '5');
INSERT INTO `materia` VALUES ('CLE-6-EXT', 'COMP. LECT', 'EXT', '6');
INSERT INTO `materia` VALUES ('DIS-1-EXT', 'DISCIPLINA', 'EXT', '1');
INSERT INTO `materia` VALUES ('DIS-2-EXT', 'DISCIPLINA', 'EXT', '2');
INSERT INTO `materia` VALUES ('DIS-3-EXT', 'DISCIPLINA', 'EXT', '3');
INSERT INTO `materia` VALUES ('DIS-4-EXT', 'DISCIPLINA', 'EXT', '4');
INSERT INTO `materia` VALUES ('EDA-1-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '1');
INSERT INTO `materia` VALUES ('EDA-2-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '2');
INSERT INTO `materia` VALUES ('EDA-3-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '3');
INSERT INTO `materia` VALUES ('EDA-4-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '4');
INSERT INTO `materia` VALUES ('EDA-5-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '5');
INSERT INTO `materia` VALUES ('EDA-6-SEP', 'EDUACIÓN ARTÍSTICA', 'SEP', '6');
INSERT INTO `materia` VALUES ('EDF-1-SEP', 'EDUCACIÓN FISICA', 'SEP', '1');
INSERT INTO `materia` VALUES ('EDF-2-SEP', 'EDUCACIÓN FISICA', 'SEP', '2');
INSERT INTO `materia` VALUES ('EDF-3-SEP', 'EDUCACIÓN FISICA', 'SEP', '3');
INSERT INTO `materia` VALUES ('EDF-4-SEP', 'EDUCACIÓN FISICA', 'SEP', '4');
INSERT INTO `materia` VALUES ('EDF-5-SEP', 'EDUCACIÓN FISICA', 'SEP', '5');
INSERT INTO `materia` VALUES ('EDF-6-SEP', 'EDUCACIÓN FISICA', 'SEP', '6');
INSERT INTO `materia` VALUES ('EDV-3-SEP', 'LA ENTIDAD DONDE VIVO', 'SEP', '3');
INSERT INTO `materia` VALUES ('ENS-1-SEP', 'EXPLORACIÓN DE LA NATURALEZA Y LA SOCIEDAD', 'SEP', '1');
INSERT INTO `materia` VALUES ('ENS-2-SEP', 'EXPLORACIÓN DE LA NATURALEZA Y LA SOCIEDAD 2', 'SEP', '2');
INSERT INTO `materia` VALUES ('ESP-1-SEP', 'ESPAÑOL 1', 'SEP', '1');
INSERT INTO `materia` VALUES ('ESP-2-SEP', 'ESPAÑOL 2', 'SEP', '2');
INSERT INTO `materia` VALUES ('ESP-3-SEP', 'ESPAÑOL 3', 'SEP', '3');
INSERT INTO `materia` VALUES ('ESP-4-SEP', 'ESPAÑOL 4', 'SEP', '4');
INSERT INTO `materia` VALUES ('ESP-5-SEP', 'ESPAÑOL 5', 'SEP', '5');
INSERT INTO `materia` VALUES ('ESP-6-SEP', 'ESPAÑOL 6', 'SEP', '6');
INSERT INTO `materia` VALUES ('FCE-1-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '1');
INSERT INTO `materia` VALUES ('FCE-2-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '2');
INSERT INTO `materia` VALUES ('FCE-3-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '3');
INSERT INTO `materia` VALUES ('FCE-4-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '4');
INSERT INTO `materia` VALUES ('FCE-5-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '5');
INSERT INTO `materia` VALUES ('FCE-6-SEP', 'FORMACIÓN CÍVICA Y ÉTICA', 'SEP', '6');
INSERT INTO `materia` VALUES ('GEO-4-SEP', 'GEOGRAFÍA', 'SEP', '4');
INSERT INTO `materia` VALUES ('GEO-5-SEP', 'GEOGRAFÍA 2', 'SEP', '5');
INSERT INTO `materia` VALUES ('GEO-6-SEP', 'GEOGRAFÍA 3', 'SEP', '6');
INSERT INTO `materia` VALUES ('HIS-4-SEP', 'HISTORIA', 'SEP', '4');
INSERT INTO `materia` VALUES ('HIS-5-SEP', 'HISTORIA 2', 'SEP', '5');
INSERT INTO `materia` VALUES ('HIS-6-SEP', 'HISTORIA 3', 'SEP', '6');
INSERT INTO `materia` VALUES ('MAT-1-SEP', 'MATEMATICAS 1', 'SEP', '1');
INSERT INTO `materia` VALUES ('MAT-2-SEP', 'MATEMATICAS 2', 'SEP', '2');
INSERT INTO `materia` VALUES ('MAT-3-SEP', 'MATEMATICAS 3', 'SEP', '3');
INSERT INTO `materia` VALUES ('MAT-4-SEP', 'MATEMATICAS 4', 'SEP', '4');
INSERT INTO `materia` VALUES ('MAT-5-SEP', 'MATEMATICAS 5', 'SEP', '5');
INSERT INTO `materia` VALUES ('MAT-6-SEP', 'MATEMATICAS 6', 'SEP', '6');
INSERT INTO `materia` VALUES ('ORT-2-EXT', 'ORTOGRAFÍA', 'EXT', '2');
INSERT INTO `materia` VALUES ('ORT-3-EXT', 'ORTOGRAFÍA', 'EXT', '3');
INSERT INTO `materia` VALUES ('ORT-4-EXT', 'ORTOGRAFÍA', 'EXT', '4');
INSERT INTO `materia` VALUES ('ORT-5-EXT', 'ORTOGRAFÍA', 'EXT', '5');
INSERT INTO `materia` VALUES ('ORT-6-EXT', 'ORTOGRAFÍA', 'EXT', '6');
INSERT INTO `materia` VALUES ('PAR-2-EXT', 'PARTICIPACIÓN', 'EXT', '2');
INSERT INTO `materia` VALUES ('PAR-4-EXT', 'PARTICIPACIÓN', 'EXT', '4');
INSERT INTO `materia` VALUES ('PAR-5-EXT', 'PARTICIPACIÓN', 'EXT', '5');
INSERT INTO `materia` VALUES ('PAR-6-EXT', 'PARTICIPACIÓN', 'EXT', '6');
INSERT INTO `materia` VALUES ('PUN-1-EXT', 'PUNTUALIDAD', 'EXT', '1');
INSERT INTO `materia` VALUES ('TAR-1-EXT', 'TAREAS', 'EXT', '1');
INSERT INTO `materia` VALUES ('TAR-2-EXT', 'TAREAS', 'EXT', '2');
INSERT INTO `materia` VALUES ('TAR-3-EXT', 'TAREAS', 'EXT', '3');
INSERT INTO `materia` VALUES ('TAR-4-EXT', 'TAREAS', 'EXT', '4');
INSERT INTO `materia` VALUES ('TAR-5-EXT', 'TAREAS', 'EXT', '5');
INSERT INTO `materia` VALUES ('TAR-6-EXT', 'TAREAS', 'EXT', '6');
INSERT INTO `materia` VALUES ('TRA-5-EXT', 'TRABAJOS', 'EXT', '5');
INSERT INTO `materia` VALUES ('UYA-1-EXT', 'UNIFORME Y ASEO', 'EXT', '1');
INSERT INTO `materia` VALUES ('UYA-2-EXT', 'UNIFORME Y ASEO', 'EXT', '2');
INSERT INTO `materia` VALUES ('UYA-3-EXT', 'UNIFORME Y ASEO', 'EXT', '3');
INSERT INTO `materia` VALUES ('UYA-6-EXT', 'UNIFORME Y ASEO', 'EXT', '6');

-- ----------------------------
-- Table structure for tutor
-- ----------------------------
DROP TABLE IF EXISTS `tutor`;
CREATE TABLE `tutor`  (
  `curp_tutor` varchar(18) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ap_pat_tutor` varchar(35) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `ap_mat_tutor` varchar(35) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nombre_tutor` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `tel_cel_tutor` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `tel_casa_tutor` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `tel_extra_tutor` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `email_tutor` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `email_extra_tutor` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `municipio_direc` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `colonia_direc` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `calle_direc` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `cp_direc` varchar(8) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `numcalle_direc` varchar(8) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`curp_tutor`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tutor
-- ----------------------------
INSERT INTO `tutor` VALUES ('AAFA841103MGRVIN05', 'Avalos', 'Feito', 'Ana Maria', '7444630507', '7442811275', '7442502071', 'ujassakod-0984@yopmail.com', '', 'Coyuca de Benitez', 'Embarcadero', 'San cristobal', '32223', '49');
INSERT INTO `tutor` VALUES ('AAFA861006HGRYRL05', 'Ayala', 'Fernandez', 'Alex', '7441319620', '7442021538', '', 'elliqedde-6643@yopmail.com', 'hanavacavi-4125@yopmail.com', 'Coyuca de Benitez', 'Coyuca de benitez', 'Esquina', '46843', '88');
INSERT INTO `tutor` VALUES ('AAFD861204HGRRSN03', 'Aragones', 'Fausto', 'Daniel', '7443911795', '7446244708', '7444981193', 'izimmepeppe-4610@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'Polideportivo', '52455', '77');
INSERT INTO `tutor` VALUES ('AOZA810101HGRZMI04', 'Azcona', 'Zambrano', 'Aitor', '7447128023', '7443373664', '', 'denixossu-5239@yopmail.com', '', 'Coyuca de Benitez', 'El aguacate', 'El aguacate', '56998', '85');
INSERT INTO `tutor` VALUES ('BAAC801009HGRLLR06', 'Alcazar', 'Balboa', 'Carlos', '7442671695', '7441552876', '', 'ellagige-0027@yopmail.com', '', 'Coyuca de Benitez', 'Ejido Viejo', 'Granjas', '71126', '92');
INSERT INTO `tutor` VALUES ('BAFM810304HGRRJR08', 'Fajardo', 'Bravo', 'Marcos', '7449820784', '7446305277', '7440139015', 'cozimabas-6446@yopmail.com', '', 'Coyuca de Benitez', 'Conchero', 'Lagunilla', '11635', '98');
INSERT INTO `tutor` VALUES ('BAMJ840216HGRMMN01', 'Bayo', 'Monfort', 'Francisco Javier', '7448999763', '7441711634', '', 'tatodduxotto-9031@yopmail.com', '', 'Coyuca de Benitez', 'Bajos del ejido', 'Parada', '33221', '76');
INSERT INTO `tutor` VALUES ('BAPN850606MGRRRT08', 'Barrero', 'Pariente', 'Natalia', '7443150898', '7447982661', '', 'punadexerr-7685@yopmail.com', 'firroremmomm-0997@yopmail.com', 'Coyuca de Benitez', 'Yetla', 'Carrera larga', '64649', '44');
INSERT INTO `tutor` VALUES ('BEMM820207HGRRII01', 'Florez', 'Brenes', 'Miguel Angel', '7447724098', '7446106240', '7448109719', 'jesazalenn-6403@yopmail.com', '', 'Coyuca de Benitez', 'Conchero', 'Islitas', '12332', '70');
INSERT INTO `tutor` VALUES ('CACP850506MGRTLL02', 'Cañete', 'Colorado', 'Paula', '7443884843', '7442133260', '', 'ufezecadda-8716@yopmail.com', '', 'Coyuca de Benitez', 'Yetla', 'Jose H.', '75425', '20');
INSERT INTO `tutor` VALUES ('CALJ840302MGRLYS01', 'Calero', 'Leyva', 'Josefina', '7446616774', '7445713467', '', 'nyvezesafe-5365@yopmail.com', '', 'Coyuca de Benitez', 'Yetla', 'San agustin', '64437', '99');
INSERT INTO `tutor` VALUES ('CEML830902HGRHRI02', 'Chen', 'Martel', 'Luis', '7441229505', '7447070976', '', 'yjosoxo-1842@yopmail.com', '', 'Coyuca de Benitez', 'Bajos del ejido', 'La pedrada', '23455', '27');
INSERT INTO `tutor` VALUES ('COMD911107HGRNLM06', 'Concepcion', 'Melian', 'Domingo', '7443097464', '7440396525', '', 'nossuralliv-7149@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de Benitez', 'Celit de mar', '74458', '98');
INSERT INTO `tutor` VALUES ('DONJ770907HGRBDN00', 'Doblas', 'Nadal', 'Juan Luis', '7445920543', '7441562452', '', 'ocokeddill-4385@yopmail.com', '', 'Coyuca de Benitez', 'Cerrito de oro', 'Principal', '43221', '42');
INSERT INTO `tutor` VALUES ('EEVV811009HGRCII04', 'Echeverria', 'Jareño', 'Vicente', '7446159637', '7449730904', '', 'rihediradd-6860@yopmail.com', 'tyssexotuh-1422@yopmail.com', 'Coyuca de Benitez', 'Cochero', 'Lagunilla', '55796', '82');
INSERT INTO `tutor` VALUES ('EILA611001HGRSRN06', 'Espinola', 'Lora', 'Andres', '7441965768', '7443265991', '7449564986', 'uburrycy-7277@yopmail.com', '', 'Coyuca de Benitez', 'Ejido Viejo', 'Londo', '85774', '244');
INSERT INTO `tutor` VALUES ('GASA861016HGRBZD01', 'Gabarri', 'Soza', 'Adrian', '7447538886', '7445413930', '', 'siseffyppu-3100@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'La Corte', '34333', '27');
INSERT INTO `tutor` VALUES ('GIPJ820207HGRRII01', 'Gimeno', 'Paredes', 'Julian', '7445920543', '7441562452', '', 'viddesizuse-6839@yopmail.com', 'exabufo-7817@yopmail.com', 'Coyuca de Benitez', 'Ejido Viejo', 'Las piedritas', '55711', '116');
INSERT INTO `tutor` VALUES ('GUBM831214MGRRZR03', 'Guardiola', 'Bouzas', 'Mercedes', '7446366852', '7447669485', '', 'yxollypaby-6956@yopmail.com', '', 'Coyuca de Benitez', 'El valle', 'La avenida', '13422', '78');
INSERT INTO `tutor` VALUES ('HECC800502HGRRDR08', 'Hermosilla', 'Cañadas', 'Cristobal', '7442315710', '7442850099', '', 'xehinallu-4988@yopmail.com', 'nujaddibe-2024@yopmail.com', 'Coyuca de Benitez', 'Ejido Viejo', 'Granjas', '71856', '63');
INSERT INTO `tutor` VALUES ('IOMC911212HGRBGL09', 'Iborra', 'Magno', 'Carlos', '7442101635', '7442449795', '', 'ennaliva-2318@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'La venta', '65789', '112');
INSERT INTO `tutor` VALUES ('JIAA840715MGRIRN01', 'Jimeno', 'Aragones', 'Angeles', '7442495056', '7446616382', '', 'rywonaxa-7942@yopmail.com', 'ataweppo-9467@yopmail.com', 'Coyuca de Benitez', 'Embarcadero', 'San cristobal', '32223', '55');
INSERT INTO `tutor` VALUES ('MALD831217MGRSIL00', 'Mascaro', 'Lainez', 'Dolores', '7449540597', '7444111836', '', 'effafarrurr-8905@yopmail.com', '', 'Coyuca de Benitez', 'Embarcadero', 'La parada', '43322', '633');
INSERT INTO `tutor` VALUES ('MAPJ910502HGRSRS04', 'Maestre', 'Porras', 'Jose', '7447484842', '7448715660', '', 'exokozy-8689@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de Benitez', 'Bejuco', '74522', '11');
INSERT INTO `tutor` VALUES ('MORA831008MGRRQN01', 'Moron', 'Roque', 'Angeles', '7441051668', '7446366852', '', 'yratowip-6627@yopmail.com', '', 'Coyuca de Benitez', 'El valle', 'La segunda principal', '23655', '56');
INSERT INTO `tutor` VALUES ('NEMM830407MGRVNR01', 'Nevado', 'Montes', 'Maria Josefa', '7446773166', '7446243829', '7446615234', 'usettoffew-7323@yopmail.com', '', 'Coyuca de Benitez', 'El valle', 'La avenida', '13422', '76');
INSERT INTO `tutor` VALUES ('OOAA830403MGRCGR08', 'Ochoa', 'Aguilo', 'Aurora', '7449394492', '7449740958', '7446405744', 'evugidda-2184@yopmail.com', 'ecenneppyk-6992@yopmail.com', 'Coyuca de Benitez', 'El valle', 'La primera', '23321', '225');
INSERT INTO `tutor` VALUES ('OOAA830902MGRCGR06', 'Victoria', 'Regalado', 'Sara', '7440959049', '7440147271', '7445727748', 'ocinnepa-4927@yopmail.com', 'onneffoffa-3872@yopmail.com', 'Coyuca de Benitez', 'El valle', 'El rancho', '43211', '32');
INSERT INTO `tutor` VALUES ('PICR800907HGRILI01', 'Pina', 'Collado', 'Ricardo', '7442487291', '7440413727', '', 'mupykevu-6400@yopmail.com', '', 'Coyuca de Benitez', 'Bajos del ejido', 'Parada', '33222', '77');
INSERT INTO `tutor` VALUES ('PISP860713HGRIBD09', 'Pinto', 'Subizarreta', 'Pedro', '7446072928', '7445677720', '', 'umolahivy-8377@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'Laguna larga', '55742', '67');
INSERT INTO `tutor` VALUES ('RAGJ801009HGRBIN01', 'Rabadan', 'Gil', 'Juan Manuel', '7443997485', '7448215800', '', 'affezirrog-0587@yopmail.com', 'cevibezedd-1620@yopmail.com', 'Coyuca de Benitez', 'Ejido Viejo', 'Londo', '88745', '50');
INSERT INTO `tutor` VALUES ('RARJ340216HGRMMN01', 'Ramon', 'Ramon', 'Juan', '7444608489', '7446732263', '', 'hullammynymm-9942@yopmail.com', 'ylligeman-8636@yopmail.com', 'Coyuca de Benitez', 'Ejido Viejo', 'Las piedritas', '55796', '82');
INSERT INTO `tutor` VALUES ('REME860702HGRGLD01', 'Regueira', 'Molina', 'Edgardo', '7445000941', '7448906888', '7448668856', 'ammeffaza-3210@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'Iglesia santa', '12633', '08');
INSERT INTO `tutor` VALUES ('SABJ340216HGRMMN01', 'Sarria', 'Bartolome', 'Jaime', '7442759380', '7446163500', '7445857871', 'allakyfis-6270@yopmail.com', 'kusemazeq-6754@yopmail.com', 'Coyuca de Benitez', 'Bajos del ejido', 'Principal', '44322', '23');
INSERT INTO `tutor` VALUES ('TEAJ800908HGRILS01', 'Teijeiro', 'Alarcon', 'José Antonio', '7448336096', '7440106938', '7442789996', 'ibitabe-8422@yopmail.com', '', 'Coyuca de Benitez', 'Ejido Viejo', 'La Frase', '12556', '08');
INSERT INTO `tutor` VALUES ('TEMJ210206HGRRLN07', 'Trejo', 'Melgarejo', 'Juan Francisco', '7445032431', '7440530348', '', 'ennipimmo-0261@yopmail.com', '', 'Coyuca de Benitez', 'Ejido Viejo', 'Las piedritas', '55798', '12');
INSERT INTO `tutor` VALUES ('TOLA840804MGRRMN03', 'Torralbo', 'Lomas', 'Antonia', '7444337150', '7442368448', '7443085830', 'fysuffofec-2789@yopmail.com', '', 'Coyuca de Benitez', 'Yetla', 'Ricardo F.', '73366', '110');
INSERT INTO `tutor` VALUES ('UIDL910205HGRRLS04', 'Urbina', 'De la paz', 'Leonardo', '7440035282', '7449233889', '', 'kaxeppottafa-8712@yopmail.com', '', 'Coyuca de Benitez', 'Coyuca de benitez', 'Las bombas', '44755', '45');
INSERT INTO `tutor` VALUES ('UURM970314HGRRMS18', 'URZUA', 'RAMOS', 'MISAEL', '7445757575', '7446665858', '', 'escom_97@hotmail.com', 'escom_97@hotmail.com', 'hj', 'sdas', 'sas', '14141', '47474');
INSERT INTO `tutor` VALUES ('VESG810103HGRLRN04', 'Velasquez', 'Sarria', 'Gonzalo', '7444608489', '7446732263', '', 'eribinna-2558@yopmail.com', 'illaddorrod-2203@yopmail.com', 'Coyuca de Benitez', 'El aguacate', 'El aguacate', '56987', '63');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios`  (
  `id_usuario` int(2) NOT NULL AUTO_INCREMENT,
  `nom_usuario` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `contraseña` varchar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`id_usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES (1, 'edgar', '1111');
INSERT INTO `usuarios` VALUES (2, 'Juan', '1234');

SET FOREIGN_KEY_CHECKS = 1;
