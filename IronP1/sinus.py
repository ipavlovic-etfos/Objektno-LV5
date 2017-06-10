import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import Form, ToolStripMenuItem
import math

name = 'sinus'         # postavlja se naziv funkcije koji se pojavljuje u izborniku 

def cosinus (sender,args):     # funkcija za racunanje kosinusa
    frm=sender.Tag
    A=float(frm.textBox1.Text)
    frm.textBox3.Text=str(math.sin(A))                         #u tekst box 3 se ispisuje rezultat operacije

def Dodaj(frm):                                         # funkcija za dodavanje extenzija u menu bar 

    tipka=ToolStripMenuItem(name)
    tipka.Tag=frm
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(tipka)     
    tipka.Click +=cosinus                                        #pritiskom na tipku vrsi se operacija 



