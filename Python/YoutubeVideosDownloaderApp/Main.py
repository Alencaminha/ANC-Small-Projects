from tkinter import *
from tkinter import messagebox
from pytube import YouTube
import os

# Pytube
def video_download():
    yt_video = YouTube(url_entry.get())
    video_stream = yt_video.streams.filter(progressive=True, file_extension='mp4').order_by('resolution').desc().first()
    downloads_folder = os.path.expanduser("~")+"/Downloads/"
    video_stream.download(output_path=downloads_folder)
    url_entry.delete(0, END)
    messagebox.showinfo(title="Download complete", message="The video has been correctly downloaded!")

# Tkinter
app_window = Tk()
app_window.title("Youtube Videos Downloader")
app_window.resizable(False, False)
app_window.geometry("420x100")
app_window.eval('tk::PlaceWindow . center')

text_label = Label(app_window,
                  text="Enter the video URL here",
                  font=('Arial', 20, 'bold'),
                  padx=5,
                  pady=5)
text_label.pack(side='top')

url_entry = Entry(app_window,
                  font=('Arial', 20))
url_entry.pack(side='left', padx=5)
url_entry.focus()

enter_button = Button(app_window,
                      command=video_download,
                      text="Enter",
                      font=('Arial', 18, 'bold'))
enter_button.pack(side='right', padx=5)

app_window.mainloop()
