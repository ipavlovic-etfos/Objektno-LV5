import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import Form, ToolStripMenuItem
import math

name = 'tangens' 

def cosinus (sender,args):
    frm=sender.Tag
    A=float(frm.textBox1.Text)
    frm.textBox3.Text=str(math.tan(A))

def Dodaj(frm):
    tipka=ToolStripMenuItem(name)
    tipka.Tag=frm
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(tipka)
    tipka.Click +=cosinus

