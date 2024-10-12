using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make crepes", "Alejandra Pacheco", 1200);
        video1._comments.Add(new Comment("Kenneth", "thar recipe taste like the one my granny used to make to me"));
        video1._comments.Add(new Comment("Jared","What happends if i use sweetemer instead of sugar?"));
        video1._comments.Add(new Comment("Osiris","Nice tutorial"));
        video1._comments.Add(new Comment("Yess","I think 20 minutes of tutorial is too much, watherever those cepes were soooo good"));
        video1._comments.Add(new Comment("Machadito","Que buenas crepas las que quedan"));
        video1._comments.Add(new Comment("JJJk","素晴らしいチュートリアル"));

        video1.ShowInfoVideo();
    }
}