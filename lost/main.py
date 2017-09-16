import tkinter as GUI
import time

def update():
  Win.update()

  
white = (255,255,255)
black = (0,0,0)
red = (255,0,0)
green = (0,255,0)
blue = (0,0,255)
can_width = 800
can_height = 600
cen_y = int(can_height / 2)
cen_x = int(can_width / 2)

Win = GUI.Tk()
canvas = GUI.Canvas(Win, width=can_width, height=can_height)
Win.title("GUI")
Win.minsize(800, 600)
canvas.pack()

def checkered(canvas, line_distance):
   # vertical lines at an interval of "line_distance" pixel
   for x in range(line_distance,can_width,line_distance):
      canvas.create_line(x, 0, x, can_height, fill="#476042")
   # horizontal lines at an interval of "line_distance" pixel
   for y in range(line_distance,can_height,line_distance):
      canvas.create_line(0, y, can_width, y, fill="#476042")


































checkered(canvas, 2)



























while True:
  update()

  



