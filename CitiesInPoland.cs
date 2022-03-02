﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationDesctop
{
    class CitiesInPoland
    {
       readonly static string[] citiesInPoland = {"Aleksandrów Kujawski,52.880 ,18.700 ,Kujawsko-Pomorskie"," Aleksandrów Łódzki,51.820 ,19.299 ,Łódzkie"," Andrychów,49.860 ,19.339 ,Małopolskie"," Augustów,53.839 ,23.000 ,Podlaskie"," Barlinek,52.999 ,15.199 ,Zachodnio-Pomorskie"," Bartoszyce,54.249 ,20.809 ,Warmińsko-Mazurskie"," Będzin,50.340 ,19.129 ,Śląskie"," Bełchatów,51.369 ,19.360 ,Łódzkie"," Biała Podlaska,52.039 ,23.110 ,Lubelskie"," Białogard,54.009 ,15.979 ,Zachodnio-Pomorskie"," Białystok,53.139 ,23.159 ,Podlaskie"," Bielawa,50.689 ,16.610 ,DolnoŚląskie"," Bielsk Podlaski,52.780 ,23.290 ,Podlaskie"," Bielsko-Biała,49.819 ,19.049 ,Śląskie"," Bieruń,50.100 ,19.100 ,Śląskie"," Biłgoraj,50.539 ,22.729 ,Lubelskie"," Biskupiec,53.870 ,20.950 ,Warmińsko-Mazurskie"," Blachownia,50.790 ,18.959 ,Śląskie"," Błonie,52.199 ,20.620 ,Mazowieckie"," Bochnia,49.979 ,20.429 ,Małopolskie"," Bogatynia,50.919 ,14.960 ,DolnoŚląskie"," Boguszów-Gorce,50.760 ,16.189 ,DolnoŚląskie"," Bolesławiec,51.259 ,15.560 ,DolnoŚląskie"," Braniewo,54.390 ,19.819 ,Warmińsko-Mazurskie"," Brodnica,53.259 ,19.399 ,Kujawsko-Pomorskie"," Brwinów,52.179 ,20.799 ,Mazowieckie"," Brzeg,50.849 ,17.470 ,Opolskie"," Brzeg Dolny,51.270 ,16.739 ,DolnoŚląskie"," Brzesko,49.969 ,20.600 ,Małopolskie"," Brzeszcze,49.990 ,19.149 ,Małopolskie"," Brzeziny,51.809 ,19.749 ,Łódzkie"," Bukowno,50.290 ,19.440 ,Małopolskie"," Busko-Zdrój,50.479 ,20.719 ,Świętokrzyskie"," Bydgoszcz,53.120 ,18.010 ,Kujawsko-Pomorskie"," Bystrzyca Kłodzka,50.299 ,16.639 ,DolnoŚląskie"," Bytom,50.349 ,18.909 ,Śląskie"," Bytów,54.179 ,17.470 ,Pomorskie"," Chełm,51.139 ,23.490 ,Lubelskie"," Chełmek,50.110 ,19.249 ,Małopolskie"," Chełmno,53.350 ,18.429 ,Kujawsko-Pomorskie"," Chełmża,53.180 ,18.609 ,Kujawsko-Pomorskie"," Chodzież,52.989 ,16.910 ,Wielkopolskie"," Chojnice,53.700 ,17.569 ,Pomorskie"," Chojnów,51.280 ,15.930 ,DolnoŚląskie"," Chorzów,50.299 ,19.030 ,Śląskie"," Choszczno,53.180 ,15.400 ,Zachodnio-Pomorskie"," Chrzanów,50.139 ,19.399 ,Małopolskie"," Ciechanów,52.880 ,20.620 ,Mazowieckie"," Ciechocinek,52.880 ,18.790 ,Kujawsko-Pomorskie"," Cieszyn,49.750 ,18.629 ,Śląskie"," Czarna Białostocka,53.589 ,22.579 ,Podlaskie"," Czarnków,52.910 ,16.549 ,Wielkopolskie"," Czechowice-Dziedzice,49.910 ,19.020 ,Śląskie"," Czeladź,50.320 ,19.129 ,Śląskie"," Czersk,53.800 ,17.970 ,Pomorskie"," Czerwionka-Leszczyny,50.170 ,18.680 ,Śląskie"," Częstochowa,50.810 ,19.129 ,Śląskie"," Człuchów,53.670 ,17.350 ,Pomorskie"," Dąbrowa Górnicza,50.330 ,19.180 ,Śląskie"," Dąbrowa Tarnowska,50.179 ,21.000 ,Małopolskie"," Darłowo,54.419 ,16.410 ,Zachodnio-Pomorskie"," Dębica,50.060 ,21.420 ,Podkarpackie"," Dęblin,51.569 ,21.830 ,Lubelskie"," Dębno,52.740 ,14.699 ,Zachodnio-Pomorskie"," Dobre Miasto,53.990 ,20.390 ,Warmińsko-Mazurskie"," Drawsko Pomorskie,53.529 ,15.800 ,Zachodnio-Pomorskie"," Drezdenko,52.829 ,15.829 ,Lubuskie"," Działdowo,53.229 ,20.180 ,Warmińsko-Mazurskie"," Dzierżoniów,50.729 ,16.650 ,DolnoŚląskie"," Elbląg,54.179 ,19.399 ,Warmińsko-Mazurskie"," Ełk,53.830 ,22.359 ,Warmińsko-Mazurskie"," Garwolin,51.909 ,21.620 ,Mazowieckie"," Gdańsk,54.360 ,18.639 ,Pomorskie"," Gdynia,54.520 ,18.530 ,Pomorskie"," Giżycko,54.040 ,21.759 ,Warmińsko-Mazurskie"," Gliwice,50.310 ,18.669 ,Śląskie"," Głogów,51.669 ,16.080 ,DolnoŚląskie"," Głowno,51.979 ,19.700 ,Łódzkie"," Glubczyce,50.189 ,17.830 ,Opolskie"," Głuchołazy,50.320 ,17.370 ,Opolskie"," Gniezno,52.530 ,17.610 ,Wielkopolskie"," Gołdap,54.310 ,22.309 ,Warmińsko-Mazurskie"," Goleniów,53.570 ,14.819 ,Zachodnio-Pomorskie"," Golub-Dobrzyń,53.110 ,19.040 ,Kujawsko-Pomorskie"," Góra,51.669 ,16.520 ,DolnoŚląskie"," Góra Kalwaria,51.990 ,21.209 ,Mazowieckie"," Gorlice,49.670 ,21.159 ,Małopolskie"," Gorzów Wielkopolski,52.740 ,15.230 ,Lubuskie"," Gostyń,51.879 ,17.000 ,Wielkopolskie"," Gostynin,53.430 ,19.430 ,Mazowieckie"," Grajewo,53.650 ,22.440 ,Podlaskie"," Grodków,50.700 ,17.370 ,Opolskie"," Grodzisk Mazowiecki,52.109 ,20.620 ,Mazowieckie"," Grodzisk Wielkopolski,52.230 ,16.360 ,Wielkopolskie"," Grójec,51.879 ,20.859 ,Mazowieckie"," Grudziądz,53.490 ,18.749 ,Kujawsko-Pomorskie"," Gryfice,53.919 ,15.190 ,Zachodnio-Pomorskie"," Gryfino,53.229 ,14.479 ,Zachodnio-Pomorskie"," Gubin,51.959 ,14.719 ,Lubuskie"," Hajnówka,52.729 ,23.579 ,Podlaskie"," Hrubieszów,50.810 ,23.889 ,Lubelskie"," Iława,53.589 ,19.560 ,Warmińsko-Mazurskie"," Inowrocław,52.780 ,18.249 ,Kujawsko-Pomorskie"," Janikowo,52.429 ,17.030 ,Kujawsko-Pomorskie"," Janów Lubelski,50.710 ,22.410 ,Lubelskie"," Jarocin,51.979 ,17.499 ,Wielkopolskie"," Jarosław,50.020 ,22.679 ,Podkarpackie"," Jasło,49.739 ,21.469 ,Podkarpackie"," Jastrzębie-Zdroj,49.990 ,18.590 ,Śląskie"," Jawor,51.060 ,16.200 ,DolnoŚląskie"," Jaworzno,50.209 ,19.270 ,Śląskie"," Jędrzejow,50.650 ,20.299 ,Świętokrzyskie"," Jelcz-Laskowice,51.029 ,17.299 ,DolnoŚląskie"," Jelenia Góra,50.909 ,15.729 ,DolnoŚląskie"," Józefów,52.150 ,21.260 ,Mazowieckie"," Kalety,50.570 ,18.899 ,Śląskie"," Kalisz,51.770 ,18.100 ,Wielkopolskie"," Kamień Pomorski,53.970 ,14.779 ,Zachodnio-Pomorskie"," Kamienna Góra,50.790 ,16.030 ,DolnoŚląskie"," Karczew,52.080 ,21.249 ,Mazowieckie"," Kartuzy,54.329 ,18.200 ,Pomorskie"," Katowice,50.259 ,19.020 ,Śląskie"," Kędzierzyn-Koźle,50.340 ,18.209 ,Opolskie"," Kępno,51.280 ,18.000 ,Wielkopolskie"," Kętrzyn,54.079 ,21.370 ,Warmińsko-Mazurskie"," Kęty,49.870 ,19.219 ,Małopolskie"," Kielce,50.889 ,20.649 ,Świętokrzyskie"," Kłobuck,50.909 ,18.940 ,Śląskie"," Kłodzko,50.439 ,16.659 ,DolnoŚląskie"," Kluczbork,50.980 ,18.209 ,Opolskie"," Knurów,50.220 ,18.669 ,Śląskie"," Kobyłka,52.339 ,21.200 ,Mazowieckie"," Kolno,53.419 ,21.929 ,Podlaskie"," Koło,52.199 ,18.639 ,Wielkopolskie"," Kołobrzeg,54.189 ,15.569 ,Zachodnio-Pomorskie"," Koluszki,51.750 ,19.819 ,Łódzkie"," Konin,52.209 ,18.249 ,Wielkopolskie"," Końskie,51.200 ,20.399 ,Świętokrzyskie"," Konstancin-Jeziorna,52.099 ,21.110 ,Mazowieckie"," Konstantynów Łódzki,51.750 ,19.319 ,Łódzkie"," Koronowo,53.310 ,17.929 ,Kujawsko-Pomorskie"," Kościan,52.090 ,16.639 ,Wielkopolskie"," Koscierzyna,54.130 ,17.970 ,Pomorskie"," Kostrzyn,52.589 ,14.649 ,Lubuskie"," Koszalin,54.189 ,16.180 ,Zachodnio-Pomorskie"," Kowary,50.799 ,15.829 ,DolnoŚląskie"," Kozienice,51.590 ,21.550 ,Mazowieckie"," Kożuchów,51.750 ,15.600 ,Lubuskie"," Kraków,50.060 ,19.959 ,Małopolskie"," Krapkowice,50.479 ,17.960 ,Opolskie"," Krasnik,50.929 ,22.219 ,Lubelskie"," Krasnystaw,50.990 ,23.179 ,Lubelskie"," Krosno,49.700 ,21.759 ,Podkarpackie"," Krosno Odrzańskie,52.060 ,15.100 ,Lubuskie"," Krotoszyn,51.700 ,17.430 ,Wielkopolskie"," Kruszwica,52.680 ,18.299 ,Kujawsko-Pomorskie"," Krynica,49.419 ,20.959 ,Małopolskie"," Krzeszowice,50.130 ,19.630 ,Małopolskie"," Kudowa-Zdrój,50.429 ,16.229 ,DolnoŚląskie"," Kutno,52.240 ,19.360 ,Łódzkie"," Kwidzyn,53.740 ,18.930 ,Pomorskie"," Lębork,54.549 ,17.750 ,Pomorskie"," Ledziny,50.130 ,19.059 ,Śląskie"," Legionowo,52.409 ,20.920 ,Mazowieckie"," Legnica,51.209 ,16.159 ,DolnoŚląskie"," Leszno,51.849 ,16.570 ,Wielkopolskie"," Leżajsk,50.259 ,22.420 ,Podkarpackie"," Libiąż,50.100 ,19.290 ,Małopolskie"," Lidzbark Warmiński,54.139 ,20.590 ,Warmińsko-Mazurskie"," Limanowa,49.709 ,20.419 ,Małopolskie"," Lipno,52.839 ,19.169 ,Kujawsko-Pomorskie"," Lobez,53.640 ,15.620 ,Zachodnio-Pomorskie"," Lubaczów,50.160 ,23.119 ,Podkarpackie"," Lubań,51.119 ,15.280 ,DolnoŚląskie"," Lubartów,51.459 ,22.610 ,Lubelskie"," Lubawa,53.500 ,19.749 ,Warmińsko-Mazurskie"," Lubin,51.399 ,16.200 ,DolnoŚląskie"," Lublin,51.240 ,22.570 ,Lubelskie"," Lubliniec,50.669 ,18.689 ,Śląskie"," Luboń,52.339 ,16.870 ,Wielkopolskie"," Lubsko,51.790 ,14.960 ,Lubuskie"," Lwowek Slaski,51.110 ,15.600 ,DolnoŚląskie"," Łańcut,50.069 ,22.229 ,Podkarpackie"," Łapy,52.989 ,22.890 ,Podlaskie"," Łask,51.600 ,19.140 ,Łódzkie"," Łaziska Gorne,50.170 ,18.779 ,Śląskie"," Łęczna,51.310 ,22.870 ,Lubelskie"," Łęczyca,52.069 ,19.199 ,Łódzkie"," Łódź,51.770 ,19.459 ,Łódzkie"," Łomianki,52.349 ,20.889 ,Mazowieckie"," Łomża,53.180 ,22.070 ,Podlaskie"," Łuków,51.940 ,22.390 ,Lubelskie"," Maków Mazowiecki,52.860 ,21.100 ,Mazowieckie"," Malbork,54.040 ,19.040 ,Pomorskie"," Marki,52.329 ,21.110 ,Mazowieckie"," Miastko,54.000 ,16.969 ,Pomorskie"," Miechów,50.360 ,20.019 ,Małopolskie"," Miedzychod,52.610 ,15.899 ,Wielkopolskie"," Miedzyrzec Podlaski,51.990 ,22.780 ,Lubelskie"," Miedzyrzecz,52.450 ,15.569 ,Lubuskie"," Mielec,50.290 ,21.430 ,Podkarpackie"," Mikolów,50.230 ,18.969 ,Śląskie"," Milanówek,52.130 ,20.659 ,Mazowieckie"," Milicz,51.530 ,17.270 ,DolnoŚląskie"," Mińsk Mazowiecki,52.179 ,21.559 ,Mazowieckie"," Mława,53.120 ,20.360 ,Mazowieckie"," Mogilno,52.650 ,17.960 ,Kujawsko-Pomorskie"," Mońki,53.400 ,22.780 ,Podlaskie"," Morąg,53.919 ,19.930 ,Warmińsko-Mazurskie"," Mosina,52.259 ,16.840 ,Wielkopolskie"," Mrągowo,53.880 ,21.300 ,Warmińsko-Mazurskie"," Murowana Goślina,52.580 ,17.010 ,Wielkopolskie"," Myślenice,49.839 ,19.939 ,Małopolskie"," Myśliborz,52.929 ,14.869 ,Zachodnio-Pomorskie"," Mysłowice,50.240 ,19.140 ,Śląskie"," Myszków,50.580 ,19.319 ,Śląskie"," Nakło nad Notecia,53.139 ,17.599 ,Kujawsko-Pomorskie"," Namysłów,51.079 ,17.719 ,Opolskie"," Nidzica,53.369 ,20.429 ,Warmińsko-Mazurskie"," Nisko,50.529 ,22.139 ,Podkarpackie"," Nowa Dęba,50.439 ,21.759 ,Podkarpackie"," Nowa Ruda,50.590 ,16.500 ,DolnoŚląskie"," Nowa Sól,51.809 ,15.709 ,Lubuskie"," Nowe Miasto Lubawskie,53.430 ,19.590 ,Warmińsko-Mazurskie"," Nowogard,53.660 ,15.109 ,Zachodnio-Pomorskie"," Nowy Dwór Gdański,54.220 ,19.120 ,Pomorskie"," Nowy Dwór Mazowiecki,52.429 ,20.709 ,Mazowieckie"," Nowy Sącz,49.630 ,20.699 ,Małopolskie"," Nowy Targ,49.489 ,20.030 ,Małopolskie"," Nowy Tomyśl,52.310 ,16.120 ,Wielkopolskie"," Nysa,50.479 ,17.339 ,Opolskie"," Oborniki,52.650 ,16.809 ,Wielkopolskie"," Oława,50.940 ,17.299 ,DolnoŚląskie"," Olecko,54.040 ,22.509 ,Warmińsko-Mazurskie"," Oleśnica,51.209 ,17.379 ,DolnoŚląskie"," Olesno,50.889 ,18.409 ,Opolskie"," Olkusz,50.279 ,19.549 ,Małopolskie"," Olsztyn,53.779 ,20.489 ,Warmińsko-Mazurskie"," Opalenica,52.310 ,16.399 ,Wielkopolskie"," Opoczno,51.379 ,20.280 ,Łódzkie"," Opole,50.679 ,17.940 ,Opolskie"," Opole Lubelskie,51.149 ,21.969 ,Lubelskie"," Orneta,54.119 ,20.129 ,Warmińsko-Mazurskie"," Orzesze,50.160 ,18.779 ,Śląskie"," Ostróda,53.710 ,19.959 ,Warmińsko-Mazurskie"," Ostrołęka,53.090 ,21.569 ,Mazowieckie"," Ostrów Mazowiecki,52.799 ,21.900 ,Mazowieckie"," Ostrów Wielkopolski,51.660 ,17.799 ,Wielkopolskie"," Ostrowiec Świętokrzyski,50.950 ,21.389 ,Świętokrzyskie"," Ostrzeszów,51.419 ,17.950 ,Wielkopolskie"," Oświecim,50.039 ,19.259 ,Małopolskie"," Otwock,52.109 ,21.280 ,Mazowieckie"," Ozimek,50.689 ,18.219 ,Opolskie"," Ozorków,51.969 ,19.290 ,Łódzkie"," Pabianice,51.669 ,19.350 ,Łódzkie"," Parczew,51.639 ,22.900 ,Lubelskie"," Pasłęk,54.069 ,19.659 ,Warmińsko-Mazurskie"," Piaseczno,52.069 ,21.020 ,Mazowieckie"," Piastów,52.209 ,20.920 ,Mazowieckie"," Piekary Śląskie,50.400 ,18.959 ,Śląskie"," Pieszyce,50.720 ,16.590 ,DolnoŚląskie"," Piła,53.149 ,16.739 ,Wielkopolskie"," Pińczów,50.539 ,20.529 ,Świętokrzyskie"," Pionki,51.490 ,21.459 ,Mazowieckie"," Piotrków Trybunalski,51.409 ,19.700 ,Łódzkie"," Pisz,53.630 ,21.799 ,Warmińsko-Mazurskie"," Pleszew,51.909 ,17.779 ,Wielkopolskie"," Płock,52.550 ,19.700 ,Mazowieckie"," Płonsk,52.629 ,20.379 ,Mazowieckie"," Polaniec,50.429 ,21.280 ,Świętokrzyskie"," Polczyn-Zdrój,53.770 ,16.100 ,Zachodnio-Pomorskie"," Police,53.549 ,14.559 ,Zachodnio-Pomorskie"," Polkowice,51.500 ,16.049 ,DolnoŚląskie"," Poniatowa,51.180 ,22.120 ,Lubelskie"," Poręba,50.489 ,19.339 ,Śląskie"," Poznań,52.399 ,16.900 ,Wielkopolskie"," Prudnik,50.330 ,17.569 ,Opolskie"," Pruszcz Gdański,54.255 ,18.649 ,Pomorskie"," Pruszków,52.220 ,20.819 ,Mazowieckie"," Przasnysz,53.010 ,20.879 ,Mazowieckie"," Przemyśl,49.790 ,22.780 ,Podkarpackie"," Przeworsk,50.069 ,22.500 ,Podkarpackie"," Pszczyna,49.979 ,18.950 ,Śląskie"," Pszów,50.039 ,18.400 ,Śląskie"," Puck,54.709 ,18.400 ,Pomorskie"," Puławy,51.430 ,21.980 ,Lubelskie"," Pułtusk,52.710 ,21.089 ,Mazowieckie"," Pyrzyce,53.139 ,14.879 ,Zachodnio-Pomorskie"," Pyskowice,50.410 ,18.620 ,Śląskie"," Rabka,49.619 ,19.939 ,Małopolskie"," Raciborz,50.090 ,18.219 ,Śląskie"," Radlin,50.039 ,18.459 ,Śląskie"," Radom,51.399 ,21.159 ,Mazowieckie"," Radomsko,51.069 ,19.440 ,Łódzkie"," Radzionków,50.390 ,18.889 ,Śląskie"," Radzyn Podlaski,51.790 ,22.620 ,Lubelskie"," Rawa Mazowiecka,51.770 ,20.260 ,Łódzkie"," Rawicz,51.609 ,16.860 ,Wielkopolskie"," Reda,54.620 ,18.340 ,Pomorskie"," Rogożno,52.750 ,16.979 ,Wielkopolskie"," Ropczyce,50.069 ,21.749 ,Podkarpackie"," Ruda Śląska,50.299 ,18.880 ,Śląskie"," Rumia,54.590 ,18.370 ,Pomorskie"," Rybnik,50.100 ,18.549 ,Śląskie"," Rydultowy,50.069 ,18.429 ,Śląskie"," Ryki,51.639 ,21.929 ,Lubelskie"," Rypin,53.069 ,19.410 ,Kujawsko-Pomorskie"," Rzeszów,50.049 ,21.999 ,Podkarpackie"," Sandomierz,50.689 ,21.740 ,Świętokrzyskie"," Sanok,49.570 ,22.209 ,Podkarpackie"," Sępólno Krajeńskie,53.449 ,17.530 ,Kujawsko-Pomorskie"," Siedlce,52.169 ,22.280 ,Mazowieckie"," Siemianowice Śląskie,50.330 ,19.049 ,Śląskie"," Siemiatycze,52.419 ,22.870 ,Podlaskie"," Sieradz,51.600 ,18.740 ,Łódzkie"," Sierpc,52.860 ,19.650 ,Mazowieckie"," Skarzysko-Kamienna,51.119 ,20.879 ,Świętokrzyskie"," Skawina,49.979 ,19.830 ,Małopolskie"," Skierniewice,51.959 ,20.139 ,Łódzkie"," Skoczów,49.800 ,18.799 ,Śląskie"," Skwierzyna,52.589 ,15.489 ,Lubuskie"," Sławno,54.349 ,16.670 ,Zachodnio-Pomorskie"," Słubice,52.359 ,14.569 ,Lubuskie"," Słupca,52.290 ,17.879 ,Wielkopolskie"," Słupsk,54.470 ,17.019 ,Pomorskie"," Sochaczew,52.230 ,20.229 ,Mazowieckie"," Sokółka,53.400 ,23.500 ,Podlaskie"," Sokołow Podlaski,52.409 ,22.239 ,Mazowieckie"," Solec Kujawski,53.069 ,18.230 ,Kujawsko-Pomorskie"," Sopot,54.439 ,18.559 ,Pomorskie"," Sosnowiec,50.279 ,19.120 ,Śląskie"," Stalowa Wola,50.570 ,22.049 ,Podkarpackie"," Starachowice,51.060 ,21.070 ,Świętokrzyskie"," Stargard Szczeciński,53.340 ,15.020 ,Zachodnio-Pomorskie"," Starogard Gdański,53.970 ,18.520 ,Pomorskie"," Stary Sącz,49.570 ,20.640 ,Małopolskie"," Staszów,50.560 ,21.180 ,Świętokrzyskie"," Strzegom,50.959 ,16.350 ,DolnoŚląskie"," Strzelce Krajenskie,52.869 ,15.529 ,Lubuskie"," Strzelce Opolskie,50.520 ,18.299 ,Opolskie"," Strzelin,50.780 ,17.069 ,DolnoŚląskie"," Sucha Beskidzka,49.750 ,19.590 ,Małopolskie"," Suchedniów,51.069 ,20.830 ,Świętokrzyskie"," Sulechów,52.090 ,15.620 ,Lubuskie"," Sulecin,52.450 ,15.109 ,Lubuskie"," Sulejówek,52.250 ,21.270 ,Mazowieckie"," Suwałki,54.109 ,22.940 ,Podlaskie"," Swarzędz,52.409 ,17.069 ,Wielkopolskie"," Syców,51.300 ,17.709 ,DolnoŚląskie"," Szamotuły,52.610 ,16.580 ,Wielkopolskie"," Szczecin,53.430 ,14.529 ,Zachodnio-Pomorskie"," Szczecinek,53.710 ,16.689 ,Zachodnio-Pomorskie"," Szczytno,53.559 ,20.990 ,Warmińsko-Mazurskie"," Szprotawa,51.569 ,15.520 ,Lubuskie"," Sztum,53.849 ,18.959 ,Pomorskie"," Szubin,53.010 ,17.719 ,Kujawsko-Pomorskie"," Szydłowiec,51.229 ,20.859 ,Mazowieckie"," Śrem,52.090 ,17.010 ,Wielkopolskie"," Środa Wielkopolska,52.220 ,17.270 ,Wielkopolskie"," Świdnica,50.849 ,16.489 ,DolnoŚląskie"," Świdnik,51.219 ,22.790 ,Lubelskie"," Świdwin,53.770 ,15.779 ,Zachodnio-Pomorskie"," Świebodzice,50.860 ,16.329 ,DolnoŚląskie"," Świebodzin,52.259 ,15.529 ,Lubuskie"," Świecie,53.400 ,18.440 ,Kujawsko-Pomorskie"," Świętochłowice,50.290 ,18.940 ,Śląskie"," Świnoujście,53.909 ,14.249 ,Zachodnio-Pomorskie"," Tarnobrzeg,50.590 ,21.680 ,Podkarpackie"," Tarnów,50.009 ,20.990 ,Małopolskie"," Tarnowskie Góry,50.459 ,18.860 ,Śląskie"," Tczew,54.099 ,18.779 ,Pomorskie"," Tomaszów Lubelski,50.459 ,23.419 ,Lubelskie"," Tomaszów Mazowiecki,51.540 ,20.030 ,Łódzkie"," Toruń,53.020 ,18.609 ,Kujawsko-Pomorskie"," Trzcianka,53.040 ,16.459 ,Wielkopolskie"," Trzebiatów,54.069 ,15.260 ,Zachodnio-Pomorskie"," Trzebinia,50.160 ,19.450 ,Małopolskie"," Trzebnica,51.310 ,17.060 ,DolnoŚląskie"," Tuchola,53.589 ,17.850 ,Kujawsko-Pomorskie"," Turek,52.020 ,18.479 ,Wielkopolskie"," Tychy,50.160 ,19.000 ,Śląskie"," Ustka,54.580 ,16.850 ,Pomorskie"," Ustroń,49.719 ,18.799 ,Śląskie"," Ustrzyki Dolne,49.430 ,22.610 ,Podkarpackie"," Wabrzezno,53.280 ,18.940 ,Kujawsko-Pomorskie"," Wadowice,49.879 ,19.489 ,Małopolskie"," Wągrowiec,52.810 ,17.200 ,Wielkopolskie"," Wałbrzych,50.780 ,16.280 ,DolnoŚląskie"," Wałcz,53.270 ,16.470 ,Zachodnio-Pomorskie"," Warka,51.799 ,21.190 ,Mazowieckie"," Warszawa,52.259 ,21.020 ,Mazowieckie"," Węgorzewo,54.220 ,21.749 ,Warmińsko-Mazurskie"," Węgrów,52.399 ,22.010 ,Mazowieckie"," Wejherowo,54.599 ,18.230 ,Pomorskie"," Wesoła,52.259 ,21.200 ,Mazowieckie"," Wieliczka,49.990 ,20.090 ,Małopolskie"," Wieluń,51.219 ,18.569 ,Łódzkie"," Wisła,49.659 ,18.870 ,Śląskie"," Władysławowo,54.789 ,18.400 ,Pomorskie"," Włocławek,52.659 ,19.059 ,Kujawsko-Pomorskie"," Włodawa,51.549 ,23.559 ,Lubelskie"," Włoszczowa,50.860 ,19.969 ,Świętokrzyskie"," Wodzisław Śląski,50.039 ,18.400 ,Śląskie"," Wojkowice,50.360 ,19.010 ,Śląskie"," Wolbrom,50.390 ,19.770 ,Małopolskie"," Wolomin,52.339 ,21.229 ,Mazowieckie"," Wołów,51.329 ,16.629 ,DolnoŚląskie"," Wolsztyn,52.109 ,16.109 ,Wielkopolskie"," Wrocław,51.110 ,17.030 ,DolnoŚląskie"," Wronki,52.700 ,16.360 ,Wielkopolskie"," Września,52.320 ,17.579 ,Wielkopolskie"," Wschowa,51.799 ,16.319 ,Lubuskie"," Wysokie Mazowieckie,52.910 ,22.509 ,Podlaskie"," Wyszków,52.599 ,21.449 ,Mazowieckie"," Ząbkowice Śląskie,50.590 ,16.819 ,DolnoŚląskie"," Zabrze,50.299 ,18.779 ,Śląskie"," Zakopane,49.289 ,19.959 ,Małopolskie"," Zambrów,52.980 ,22.239 ,Podlaskie"," Zamość,50.729 ,23.260 ,Lubelskie"," Zawadzkie,50.619 ,18.459 ,Opolskie"," Zawiercie,50.489 ,19.420 ,Śląskie"," Zduńska Wola,51.609 ,18.940 ,Łódzkie"," Zdzieszowice,50.419 ,18.120 ,Opolskie"," Zgierz,51.869 ,19.410 ,Łódzkie"," Zgorzelec,51.149 ,15.009 ,DolnoŚląskie"," Ziębice,50.599 ,17.050 ,DolnoŚląskie"," Zielona Gora,51.940 ,15.489 ,Lubuskie"," Zielonka,52.299 ,21.169 ,Mazowieckie"," Złocieniec,53.529 ,16.000 ,Zachodnio-Pomorskie"," Złotoryja,51.119 ,15.909 ,DolnoŚląskie"," Złotów,53.359 ,17.030 ,Wielkopolskie"," Żabki,52.290 ,21.110 ,Mazowieckie"," Żagań,51.619 ,15.299 ,Lubuskie"," Żary,51.649 ,15.130 ,Lubuskie"," Żnin,52.850 ,17.709 ,Kujawsko-Pomorskie"," Żory,50.069 ,18.689 ,Śląskie"," Żychlin,52.250 ,19.620 ,Łódzkie"," Żyrardów,52.060 ,20.450 ,Mazowieckie"," Żywiec,49.870 ,19.180 ,Śląskie"  };
        
       public static List<City> GetCitiesList()
        {
            List<City> Cities = new List<City>();

            foreach (string city in citiesInPoland)
            {
                string[] elements = city.Split(',');
                City City = new City() {Name=elements[0], Province=elements[3]};
                City.SetLatitude(elements[1]);
                City.SetLongitude(elements[2]);
                Cities.Add(City);
            }

            return Cities;
        }
    }

    class City
    {
        public string Name { get; set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string Province { get; set; }

        public void SetLatitude(string input)
        {
            Latitude = GetDoubleFromString(input);
        }

        public void SetLongitude( string input)
        {
            Longitude = GetDoubleFromString(input);
        }

        double GetDoubleFromString(string input)
        {

            if (double.TryParse(input, out double lat))
            {
                return lat;
            }
            else
            {
                if (input.Contains('.'))
                {
                    input = input.Replace('.', ',');
                    double.TryParse(input, out lat);
                    return lat;

                }
                else if (input.Contains(','))
                {
                    input = input.Replace(',', '.');
                    double.TryParse(input, out lat);
                    return lat;
                }
            }

            return lat;
        }
    }
}
