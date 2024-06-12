﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    //zbiór obrazków wyświetlanych w konsoli
    static class AsciiArt
    {

        public static string title1 = @" __    __            __                            __                           ______           
|  \  /  \          |  \                          |  \                         /      \          
| $$ /  $$ ______  _| $$_     ______    _______  _| $$_     ______    ______  |  $$$$$$\ ______  
| $$/  $$ |      \|   $$ \   |      \  /       \|   $$ \   /      \  /      \ | $$_  \$$|      \ 
| $$  $$   \$$$$$$\\$$$$$$    \$$$$$$\|  $$$$$$$ \$$$$$$  |  $$$$$$\|  $$$$$$\| $$ \     \$$$$$$\
| $$$$$\  /      $$ | $$ __  /      $$ \$$    \   | $$ __ | $$   \$$| $$  | $$| $$$$    /      $$
| $$ \$$\|  $$$$$$$ | $$|  \|  $$$$$$$ _\$$$$$$\  | $$|  \| $$      | $$__/ $$| $$     |  $$$$$$$
| $$  \$$\\$$    $$  \$$  $$ \$$    $$|       $$   \$$  $$| $$       \$$    $$| $$      \$$    $$
 \$$   \$$ \$$$$$$$   \$$$$   \$$$$$$$ \$$$$$$$     \$$$$  \$$        \$$$$$$  \$$       \$$$$$$$
";

        public static string title2 = @" __                  __                __                              
|  \                |  \              |  \                             
| $$       ______  _| $$_    _______   \$$  _______  ________  ______  
| $$      /      \|   $$ \  |       \ |  \ /       \|        \|      \ 
| $$     |  $$$$$$\\$$$$$$  | $$$$$$$\| $$|  $$$$$$$ \$$$$$$$$ \$$$$$$\
| $$     | $$  | $$ | $$ __ | $$  | $$| $$| $$        /    $$ /      $$
| $$_____| $$__/ $$ | $$|  \| $$  | $$| $$| $$_____  /  $$$$_|  $$$$$$$
| $$     \\$$    $$  \$$  $$| $$  | $$| $$ \$$     \|  $$    \\$$    $$
 \$$$$$$$$ \$$$$$$    \$$$$  \$$   \$$ \$$  \$$$$$$$ \$$$$$$$$ \$$$$$$$ 
                                                                       ";

        public static string[] plane =
        {
@"               .------,",
@"              =\      \",
@" .---.         =\      \",
@" | C~ \         =\      \",
@" |     `----------'------'----------,",
@".'     LI.-.LI LI LI LI LI LI LI.-.LI`-.",
@"\ _/.____|_|______.------,______|_|_____)",
@"                 /      /",
@"               =/      /",
@"              =/      /",
@"             =/      /",
@"             /_____,'"
        };

        public static string[] planeCrash =
        {
@"                   ,.",
@"                ___( |___",
@"                `--- \---'",
@"                    | \",
@"                    \  \",
@"   __________________\  \___________________",
@"   \                     \                   \",
@"    ------------------    \-------------------",
@"                 (\)   \   \ (\)",
@"                        \ ' \",
@"                        :`(.)-'",
@"                        ` ; `,"
        };

        public static string raft = @"                                \
                                  \   O,
                        \___________\/ )_________/
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                                        \";

        public static string death = @"                                     ____
                              __,---'     `--.__
                           ,-'                ; `.
                          ,'                  `--.`--.
                         ,'                       `._ `-.
                         ;                     ;     `-- ;
                       ,-'-_       _,-~~-.      ,--      `.
                       ;;   `-,;    ,'~`.__    ,;;;    ;  ;
                       ;;    ;,'  ,;;      `,  ;;;     `. ;
                       `:   ,'    `:;     __/  `.;      ; ;
                        ;~~^.   `.   `---'~~    ;;      ; ;
                        `,' `.   `.            .;;;     ;'
                        ,',^. `.  `._    __    `:;     ,'
                        `-' `--'    ~`--'~~`--.  ~    ,'
                       /;`-;_ ; ;. /. /   ; ~~`-.     ;
-._                   ; ;  ; `,;`-;__;---;      `----'
   `--.__             ``-`-;__;:  ;  ;__;
 ...     `--.__                `-- `-'
`--.:::...     `--.__                ____
    `--:::::--.      `--.__    __,--'    `.
        `--:::`;....       `--'       ___  `.
            `--`-:::...     __           )  ;
                  ~`-:::...   `---.      ( ,'
                      ~`-:::::::::`--.   `-.
                          ~`-::::::::`.    ;
                              ~`--:::,'   ,'
                                   ~~`--'~";

        public static string allDead = @"        _.---,._,'
       /' _.--.<
         /'     `'
       /' _.---._____
       \.'   ___, .-'`
           /'    \\             .
         /'       `-.          -|-
        |                       |
        |                   .-'~~~`-.
        |                 .'         `.
        |                 |  R  I  P  |
        |                 |           |
        |                 |           |
         \              \\|           |//
   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
";
        public static string food = @"_____#####_____
_____########___ 
______###___###### 
_______###_____#### 
_________####______# 
___________######### 
____________######## 
_________________#### 
________________#__# 
_______________##___## 
______________#_______# 
_____________ #_________## 
____________ ##___________# 
____________##_____________## 
__________###__________########## 
____###########____##___####_### 
___##____#######___#__#####__#### 
__##____##### ###__###_##_##_#### 
__#_____#########__############# 
__###############__########## 
____#############___######### 
_____##########____ 
";

        public static string energy = @"                              z
                             z
                              Z
                    .--.  Z Z
                   / _(c\   .-.     __
                  | / /  '-;   \'-'`  `\______
                  \_\/'/ __/ )  /  )   |      \--,
                  | \`""`__-/ .'--/   /--------\  \
                   \\`  ///-\/   /   /---;-.    '-'
                                (________\  \";

        public static string animal = @"    .--.              .--.
   : (\ "". _......_ ."" /) :
    '.    `        `    .'
     /'   _        _   `\
    /     0}      {0     \
   |       /      \       |
   |     /'        `\     |
    \   | .  .==.  . |   /
     '._ \.' \__/ './ _.'
     /  ``'._-''-_.'``  \";

        public static string fireplace = @"               (  .      )
           )           (              )
                 .  '   .   '  .  '  .
        (    , )       (.   )  (   ',    )
         .' ) ( . )    ,  ( ,     )   ( .
      ). , ( .   (  ) ( , ')  .' (  ,    )
     (_,) . ), ) _) _,')  (, ) '. )  ,. (' )
    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";

        public static string wood = @"                                              ;%     
                   ,           ,                
                    :         ;                     
                     %;     %;            
                     ;%;  %%;        ,    
                       %;%;      ,  ;        
                        %;        ;%;        
                         ;%;     %;'         
                          ;%%. %@;        
                           :;bd%;          
                             :;%.            
                              `;@%. ";

        public static string axe = @"  ,:\      /:.
 //  \_()_/  \\
||   |    |   ||
||   |    |   ||
||   |____|   ||
 \\  / || \  //
  `:/  ||  \;'
       ||
       ||
       XX
       XX
       XX
       XX
       OO
       `'";

        public static string medcine = @".     |___________________________________
|-----|- - -|''''|''''|''''|''''|''''|'##\|__
|- -  |  cc 6    5    4    3    2    1 ### __]==----------------------
|-----|________________________________##/|
'     |""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""";

        public static string heart = @"  ,d88b.d88b,
  88888888888
  `Y8888888Y'
    `Y888Y'  
      `Y'";
    }
}
