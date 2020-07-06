# PongGame
#Pong Game

Windows Forms Project by: Strasho Naumov(the best student ever) and Leonid Stojkovski

1. Опис на апликацијата

- Се работи за игра наречена Pong Game, каде што со помош на панели се удира фудбал и целта е да се постигне гол, оној кој прв ќе постигне 5 голови, победува.

2. Упатство за користење

2.1. Нова игра
 На почетниот прозорец при стартување на апликацијата имаме можност да избереме игра против компјутерот или игра за двајца, како и Helpдел каде детално ни се објаснети правилата и контролите на играта.

3. Преставување на проблемот

3.1 Податочни структури

Главните податоци и функции се чуваат во класата _ **public** __**partial**__ **class** __ **Menu** _

3.1.1 Help

Со оваа класа го дефинираме Help прозорецот кој овозможува објаснување на играта

3.1.2FormPong

Со оваа класа се дефинира целото дејство на играта

3.1.3 Twoplayer

Со оваа класа се претставува делот кој што овозможува игра за двајца

3.2 Алгоритми

timer\_Tick(); - оваа функција го контролира текот на играта. Тука ги имаме функциите кои ја генерираат топката на рандом место, ја контролираат брзината на топката, контролира каде завршила топката по постигнатиот гол, ги брои головите на играчите и соопштува кој играч го победил натпреварот

FormPong\_KeyUp(); - со оваа функција се дефинира движењето на палките, односно со притискање на копчињата нагоре и надолу палката се движи соодветно.

pbSPplay\_Click(); и pbSPause\_Click() - функции за стартуравње односно за паузирање на играта, со нивните соодветни функции за отпочнување на играта и затворање на играта.

timer1\_tick(); - функција во класата Тwo player прототип на timer\_Tick(); со тоа што е додадена функција за палката на играч 2.

TwoPlayer\_KeyUp(); - со оваа функција се дефинира движење на палките и нивните соодветни копчиња
