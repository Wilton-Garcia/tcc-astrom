using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringsGlobais {

    public static string textoLogo = "ASTROM";

    public static string textoOpcaoMenu1 = "Exploração";
    public static string textoOpcaoMenu2 = "Simulações";
    public static string textoOpcaoMenu3 = "Curiosidades";
    public static string textoOpcaoMenu4 = "Informações";

    public static string textoOpcaoSelecaoExploracao1 = "Planetas";
    public static string textoOpcaoSelecaoSimulacao1 = "Sistema Solar";
    public static string textoOpcapSelecaoSimulacao2 = "Eclipse Solar";

    public static string textoOpcaoSelecaoCuriosidadePlanetas = "Planetas";
    public static string textoOpcaoSelecaoCuriosidadeEstrelas = "Estrelas";
    public static string textoOpcaoSelecaoCuriosidadeOutrosAstros = "Outros Astros";

    public static string definicaoNomeAstroPlaneta = "Planeta";
    public static string definicaoNomeAstroEstrela = "Estrela";
    public static string definicaoNomeAstroObjeto = "Objeto Estelar";

    public static string definicaoComumAstrosCategoria = "Categoria do astro: \n";
    public static string definicaoComumAstrosTempoRotacao = "O tempo de rotação deste astro é: \n";
    public static string definicaoComumAstrosTempoTranslacao = "O tempo de translação deste astro é: \n";
    public static string definicaoComunsAstrosDistanciaSol = "A distancia do sol até este planeta é de: \n";

    //Definições dos planetas
    //Mercurio
    public static string planetaMercurioNome = "Mercúrio";
    public static string planetaMercurioTempoRotacao = ":1408 Horas ou 58,6 Dias";
    public static string planetaMercurioTempoTranslacao = "88 Dias" ;
    public static string planetaMercurioDistanciaSol = "3:10 minutos";
    //Venus
    public static string planetaVenusNome = "Vénus";
    public static string planetaVenusTempoRotacao = "5832 Horas ou 243 Dias";
    public static string planetaVenusTempoTranslacao = "224 Dias e 17 Horas";
    public static string planetaVenusDistanciaSol = "6 minutos";
    //Terra
    public static string planetaTerraNome = "Terra";
    public static string planetaTerraTempoRotacao = "24 Horas ou 1 Dia";
    public static string planetaTerraTempoTranslacao = "365 dias ou 1 Ano";
    public static string planetaTerraDistanciaSol = "8 minutos luz";
    //Marte
    public static string planetaMarteNome = "Marte";
    public static string planetaMarteTempoRotacao = "24,5 Horas ou 1 Dia";
    public static string planetaMarteTempoTranslacao = "687 dias ou 1,8 Anos";
    public static string planetaMarteDistanciaSol = "13 minutos luz";
    //Jupter
    public static string planetaJupiterNome = "Jupiter";
    public static string planetaJupiterTempoRotacao = "9 Horas e 56 minutos";
    public static string planetaJupiterTempoTranslacao = "11 Anos e 315 dias";
    public static string planetaJupiterDistanciaSol = "43 minutos luz";
    //Saturno
    public static string planetaSaturnoNome = "Saturno";
    public static string planetaSaturnoTempoRotacao = "10 Horas e 15 minutos";
    public static string planetaSaturnoTempoTranslacao = "11 Anos e 315 dias";
    public static string planetaSaturnoDistanciaSol = "1 Hora e 20 minutos luz";
    //Urano
    public static string planetaUranoNome = "Urano";
    public static string planetaUranoTempoRotacao = "12 Horas e 14 minutos";
    public static string planetaUranoTempoTranslacao = "84 Anos e 13 dias";
    public static string planetaUranoDistanciaSol = "2 Horas 40 minutos luz";
    //Netuno
    public static string planetaNetunoNome = "Netuno";
    public static string planetaNetunoTempoRotacao = "16 Horas e 7 minutos";
    public static string planetaNetunoTempoTranslacao = "165";
    public static string planetaNetunoDistanciaSol = "4 Horas e 40 minutos luz";


    //Informações
    public static string informacoesGeral = @"Conceitos:
	    Tempo de Rotação:
        É o movimento que  acontece quando um astro gira ao redor de si mesmo.
	    Tempo de Translação: 
        É o nome do movimento que um astro faz ao girar ao redor de outro astro.
	    Ano/minuto luz: 
        É o tempo que se gasta para percorrer uma distancia na velocidade da luz.
        Galileu Galilei, foi o inventor da luneta, que permitu observar melhor astros e trouxe grandes avanços para astronomia";


    //Curiosidades Plaentas
    public static string textoCuriosidadesVoceSabia = "Você sabia ?";
    public static string textoCuriosidadesPadrao = @"O universo está cheio de curiosidades incrívies!
                                                       
                                                    Clique em um dos planetas ao lado para descobrir mais sobre ele ";

    public static string textoCuriosidadeGuiaPlanetas = "Você sabia que no planeta ";

    public static string textoCuriosidadeMercurio = @"O planeta do Sistema Solar que está mais próximo do Sol é Mercúrio.
                                                    
                                                    Mercúrio é também o menor planeta do sistema solar, além de ser o segundo mais quente (o mais quente é Vênus).
                                                    
                                                    A temperatura na superfície de Mercúrio pode atingir 420ºC, enquanto em Vênus ela pode chegar a 460ºC (também na superfície).";

    public static string textoCuriosidadeVenus   = @" É o segundo objeto mais brilhante do céu noturno (após a Lua) e é visível durante uma pequena parte do dia.
⠀                                                   
                                                    Um dia em Vênus dura mais que um ano. O seu período de rotação é mais longo do que qualquer outro planeta.
⠀                                                   
                                                    Vênus é o planeta mais quente do Sistema Solar, Vênus atinge temperaturas superiores a 462ºC.";

    public static string textoCuriosidadeTerra = @"E o terceiro planeta mais perto do Sol, e o planeta que vivemos°
                                                   
                                                    E o único planeta conhecido em que se desenvolveu vida.
                                                   
                                                    A temperatura mais alta registrada na terra foi de 56°C e a mais baixa foi de -89°C, a temperatura média da terra é de 15°C
                                                   
                                                    A terra tem um satélite próprio, seu nome é Lua, ela não tem luz própria, mas reflete a luz do sol";

    public static string textoCuriosidadeMarte = @"Um dia de sol em Marte é 3% mais longo que aqui, ou seja, tem 24 horas, 37 minutos e 23 segundos. O ano marciano, que é o tempo que o planeta leva para dar uma volta completa em torno do Sol, possui 669 'sóis' (ou dias).
                                                   
                                                   O Monte Olimpo, em Marte, é o maior vulcão do Sistema Solar, com 624 km de diâmetro e 25 km de altura.O vulcão, que é três vezes mais alto do que o Monte Everest, não está mais em atividade.
                                                   
                                                   Trata-se do planeta com ambiente que mais se assemelha com o da Terra: a composição do solo é parecida e há água em seu subsolo";

    public static string textoCuriosidadeJupiter = @"A gravidade em Júpiter é 2,4 vezes mais forte do que a da Terra, o que significa que uma pessoa de 100 quilos pesaria 240 kg no planeta
                                                    
                                                    Júpiter é um dos cinco planetas que podem ser vistos a olho nu aqui da Terra, e é o quarto objeto mais brilhante no céu depois do Sol, da Lua e de Vênus
                                                    
                                                    Júpiter é o maior planeta do nosso Sistema Solar. Ele é duas vezes maior que todos os asteroides, cometas, planetas e satélites do nosso Sistema Solar.
                                                    
                                                    Caso o planeta fosse oco, caberiam cerca de 1.200 Terras dentro de Júpite
                                                    
                                                    Júpiter possui uma famosa mancha vermelha causada por uma tempestade que já dura 400 anos, essa mancha é três vezes maior que a Terra";

    public static string textoCuriosidadeSaturno = @"Saturno poderia flutuar no oceano, Saturno é feito principalmente de hidrogênio, e é o planeta menos denso no Sistema Solar.
                                                    
                                                    Em compensação, quando falamos de massa, Saturno e Júpiter juntos representam 92% de toda a massa planetária no sistema solar.
                                                    
                                                    Saturno tem 62 luas, e uma delas talvez possa abrigar vida,";

    public static string textoCuriosidadeUrano = @"Urano possui  tempestades monstruosas com ventos que podem alcançar os 900 quilômetros por hora.

                                                   Urano tem a atmosfera mais fria do Sistema Solar, com temperaturas mínimas que chegam a – 224 °C!

                                                   Aproximadamente 80% da massa de Urano é composta por uma mistura fluida de gelos de metano, água e amônia, e em sua atmosfera também é possível encontrar hidrogênio e hélio

                                                   Urano foi o primeiro planeta do Sistema Solar a ser descoberto com a ajuda de um telescópio";

    public static string textoCuriosidadeNetuno = @"Os ventos desse planeta podem chegar a até 2.400 quilômetros por hora, os mais rápidos detectados no Sistema Solar.

                                                   Netuno foi o primeiro planeta encontrado a partir de uma previsão matemática.

                                                   Por muito tempo Netuno foi considerado como o penúltimo planeta do Sistema Solar, mas com a reclassificação realizada em 2006, a qual denominou Plutão de planeta anão, Netuno passou a ser o último planeta reconhecido do Sistema Solar.";
}
