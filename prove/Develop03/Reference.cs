using System;
using System.Collections.Generic;
using System.Linq;

class Reference {
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        this.Book = book;
        this.Chapter = chapter;
        this.Verse = verse;
    }

    public override string ToString() {
        return $"{this.Book} {this.Chapter}:{this.Verse}";
    }
}