using System.Diagnostics;
Random random = new Random();
const string Menu = @" 
Quick Draw 
Face your opponent and wait for the signal. Once the signal is given, shoot your opponent by pressing [space]
before they shoot you. It's all about your reaction time. 
Choose Your Opponent: 
[1] Easy....1000 milliseconds 
[2] Medium...500 milliseconds 
[3] Hard.....250 milliseconds 
[4] Harder...125 milliseconds";
const string Wait = @" 
 O                  O
|/|      wait      || 
/\                    /\ 
/ |                  | \ 
------------------------------------------------------";
const string Fire = @" 
        ** 
        * FIRE * 
 O     **     O 
|/|                || 
/\      spacebar      /\ 
/ |                  | \ 
------------------------------------------------------";
const string LoseTooSlow = @" 
                        
╗__O 
//         Too Slow        / \ 
O/__/\     You Lose       /\ 
     \                   | \ 
---------------------------------