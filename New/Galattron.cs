using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ita {
    class Galattron {
        private static void initialGuy() {
            Console.BackgroundColor=ConsoleColor.Cyan;
            Console.SetCursorPosition(74,21);Console.Write("   ");
            Console.SetCursorPosition(74,22);Console.Write("   ");
            Console.SetCursorPosition(75,23);Console.Write(" ");
            Console.SetCursorPosition(72,24);Console.Write("       ");
            Console.SetCursorPosition(75,25);Console.Write(" ");
            Console.SetCursorPosition(74,26);Console.Write("   ");
            Console.SetCursorPosition(73,27);Console.Write(" ");
            Console.SetCursorPosition(77,27);Console.Write(" ");
            Console.ResetColor();

        }
        private static void leftGuy() {
            Console.BackgroundColor=ConsoleColor.Cyan;
            Console.SetCursorPosition(74,21);Console.Write(" ");
            Console.SetCursorPosition(74,22);Console.Write(" ");
            Console.SetCursorPosition(72,24);Console.Write("   ");
            Console.ResetColor();
            Console.SetCursorPosition(76,21);Console.Write(" ");
            Console.SetCursorPosition(76,22);Console.Write(" ");
            Console.SetCursorPosition(76,24);Console.Write("    ");
        }
        private static void rightGuy() {
            Console.ResetColor();
            Console.SetCursorPosition(74,21);Console.Write(" ");
            Console.SetCursorPosition(74,22);Console.Write(" ");
            Console.SetCursorPosition(72,24);Console.Write("   ");
            Console.BackgroundColor=ConsoleColor.Cyan;
            Console.SetCursorPosition(76,21);Console.Write(" ");
            Console.SetCursorPosition(76,22);Console.Write(" ");
            Console.SetCursorPosition(76,24);Console.Write("   ");
            Console.ResetColor();
        }
        private static void leftEnemy(int x) {
            Console.BackgroundColor=ConsoleColor.Red;
            Console.SetCursorPosition(x,21);Console.Write("    ");
            Console.SetCursorPosition(x,22);Console.Write("  ");
            Console.SetCursorPosition(x+3,22);Console.Write("   ");
            Console.SetCursorPosition(x,23);Console.Write("    ");
            Console.SetCursorPosition(x,24);Console.Write("      ");
            Console.SetCursorPosition(x,25);Console.Write("    ");
            Console.SetCursorPosition(x,26);Console.Write(" ");
            Console.SetCursorPosition(x+3,26);Console.Write(" ");
            Console.SetCursorPosition(x,27);Console.Write("  ");
            Console.SetCursorPosition(x+3,27);Console.Write("  ");
            Console.ResetColor();
        }
        private static void rightEnemy(int x) {
            Console.BackgroundColor=ConsoleColor.Red;
            Console.SetCursorPosition(x-4,21);Console.Write("    ");
            Console.SetCursorPosition(x-6,22);Console.Write("   ");
            Console.SetCursorPosition(x-2,22);Console.Write("  ");
            Console.SetCursorPosition(x-4,23);Console.Write("    ");
            Console.SetCursorPosition(x-6,24);Console.Write("      ");
            Console.SetCursorPosition(x-4,25);Console.Write("    ");
            Console.SetCursorPosition(x-4,26);Console.Write(" ");
            Console.SetCursorPosition(x-1,26);Console.Write(" ");
            Console.SetCursorPosition(x-5,27);Console.Write("  ");
            Console.SetCursorPosition(x-2,27);Console.Write("  ");
            Console.ResetColor();
        }
        private static void re() {
            Letter.mR(45,5,ConsoleColor.Green);
            Letter.mE(49,5,ConsoleColor.Green);
        }
        private static void start(int a) {
            ConsoleColor f=new ConsoleColor();
            f=ConsoleColor.Green;
            int x=40;
            Letter.mS(13+x,5,f);
            Letter.mT(17+x,5,f);
            Letter.mA(21+x,5,f);
            Letter.mR(25+x,5,f);
            Letter.mT(29+x,5,f);
            Letter.mEq(35+x,5,f);
            Letter.mS(39+x,5,f);
            Letter.mP(43+x,5,f);
            Letter.mA(47+x,5,f);
            Letter.mC(51+x,5,f);
            Letter.mE(55+x,5,f);
            f=ConsoleColor.Red;
            Letter.mM(14+x,13,f);
            Letter.mE(18+x,13,f);
            Letter.mN(22+x,13,f);
            Letter.mU(28+x,13,f);
            Letter.mEq(35+x,13,f);
            Letter.mE(43+x,13,f);
            Letter.mS(47+x,13,f);
            Letter.mC(51+x,13,f);
            int h=Letter.mPhrase("initial velocity",30,20,ConsoleColor.White);
            h+=Letter.mRightArrow(h+5,20,ConsoleColor.White)+5;
            updateValue(a);
            
        }
        private static void updateValue(int a) {
            Letter.clearZone(99,20,115,25,ConsoleColor.Black);
            if(a.ToString().Length==1) {Letter.mPhrase(a.ToString(),103,20,ConsoleColor.White);}
            else if(a.ToString().Length==2) {Letter.mPhrase(a.ToString(),101,20,ConsoleColor.White); }
            else if(a.ToString().Length==3) {Letter.mPhrase(a.ToString(),99,20,ConsoleColor.White);}
            Letter.mLeftArrow(111,20,ConsoleColor.White);
        }
        private static void prinPoint(int point) {
            for(int a=0;a<point.ToString().Length;a++) {
                    if(point.ToString().ToCharArray()[a]=='0') {Letter.m0(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='1') {Letter.m1(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='2') {Letter.m2(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='3') {Letter.m3(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='4') {Letter.m4(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='5') {Letter.m5(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='6') {Letter.m6(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='7') {Letter.m7(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='8') {Letter.m8(a*4+2,1,ConsoleColor.Cyan); }
                    else if(point.ToString().ToCharArray()[a]=='9') {Letter.m9(a*4+2,1,ConsoleColor.Cyan); }
                }
        }
        private static bool jhjh=true;
        private static int sltime=100;
        private static List<int>list=new List<int>();
        private static List<int>pos=new List<int>();
        private static List<int>starH=new List<int>();
        private static List<int>starL=new List<int>();
        public static void gala1()
        {
            Random rnd=new Random(Environment.TickCount);
            Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int jiji=Console.BufferHeight;
            int ijij=Console.WindowHeight;
            int lili=Console.BufferWidth;
            int ilil=Console.WindowWidth;
            Console.SetWindowSize(150,30);
            Console.SetBufferSize(150,30);
            int rep=0,posGuy=0,point=0;
            if(jhjh) {
                start(sltime);
            while(true) {
                cki=Console.ReadKey();
                if(cki.Key==ConsoleKey.Escape) {Program.Main();}
                else if(cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.LeftArrow&&sltime>0) {sltime--;updateValue(sltime); }
                else if(cki.Key==ConsoleKey.RightArrow&&sltime<250) {sltime++;updateValue(sltime); }
                
            }
            jhjh=false;
            }
            int oldsl=sltime;
            starH.Add(rnd.Next(1,21));starL.Add(1);
            bool can=true;
            list.Clear();pos.Clear();starL.Clear();starH.Clear();
            while(true) {
                Thread.Sleep(sltime);
                Console.ResetColor();Console.Clear();
                  starH.Add(rnd.Next(1,21));starL.Add(1);
            if(starL[0]>=149) {starL.RemoveAt(0);starH.RemoveAt(0); }
            Console.BackgroundColor=ConsoleColor.White;
            for(int a=0;a<starH.Count;a++) {starL[a]++; Console.SetCursorPosition(starL[a],starH[a]);
                Console.Write(" "); }
            prinPoint(point);
                if(Console.KeyAvailable) {cki=Console.ReadKey();
                    if(cki.Key==ConsoleKey.LeftArrow||cki.Key==ConsoleKey.A) {posGuy=1;leftGuy();}
                    else if(cki.Key==ConsoleKey.RightArrow||cki.Key==ConsoleKey.D) {posGuy=2;rightGuy();}
                }
                
                initialGuy();if(posGuy==1) {leftGuy();}else if(posGuy==2){rightGuy();}

                for(int a=0;a<pos.Count;a++) {if(pos[a]==0) {list[a]++;leftEnemy(list[a]);}else {list[a]--;rightEnemy(list[a]);} }
                try {
                    if (list[0]==68) {if(posGuy==1) {pos.RemoveAt(0);list.RemoveAt(0);point++;}else{break;}}
                    else if (list[0]==66||list[0]==67) {if(posGuy==1) {pos.RemoveAt(0);list.RemoveAt(0);point++;}}
                    else if (list[0]==84||list[0]==85) {if(posGuy==2) {pos.RemoveAt(0);list.RemoveAt(0);point++;}}
                    else if(list[0]==83) {if(posGuy==2) {pos.RemoveAt(0);list.RemoveAt(0);point++;}else{break;}}
                }catch(ArgumentOutOfRangeException) { }
                rep++;
                if(rep%5==0) {can=true;}
                if(can) {
                    if (rnd.Next(5)%4==0) {
                        can=false;int j=rnd.Next(2);pos.Add(j);if(j==0) {list.Add(2); } else { list.Add(148);}
                    }
                }
                if(rep==50&&sltime>0) {rep=0;sltime--; }
              
            }
            Console.ReadKey();
            Console.Clear();
            sltime=oldsl;
            prinPoint(point);re();
            start(sltime);
            while(true) {
                cki=Console.ReadKey();
                if(cki.Key==ConsoleKey.Escape) {Program.Main();}
                else if(cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.LeftArrow&&sltime>0) {sltime--;updateValue(sltime); }
                else if(cki.Key==ConsoleKey.RightArrow&&sltime<250) {sltime++;updateValue(sltime); }
            }
        }

        public static void gala()
        {
            while (true) { Console.Clear(); gala1(); }
        }
    }
}
