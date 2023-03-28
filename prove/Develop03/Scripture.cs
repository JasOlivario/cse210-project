class Scripture {
    private List<Word> words;

    public Reference Reference { get; set; }

    public Scripture(Reference reference, string text) {
        this.Reference = reference;
        this.words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetRenderedText() {
        return string.Join(" ", this.words.Select(w => w.GetRenderedText()));
    }

    public void HideWords(int count) {
        Random rnd = new Random();
        for (int i = 0; i < count; i++) {
            int index = rnd.Next(this.words.Count);
            if (!this.words[index].IsHidden()) {
                this.words[index].Hide();
            }
            else {
                i--;
            }
        }
    }

    public bool IsCompletelyHidden() {
        return this.words.All(w => w.IsHidden());
    }
}
