class Word {
    private string text;
    private bool hidden;

    public Word(string text) {
        this.text = text;
        this.hidden = false;
    }

    public string Hide() {
        if (!this.hidden) {
            this.hidden = true;
            return new string('_', this.text.Length);
        }
        return this.text;
    }

    public void Show() {
        this.hidden = false;
    }

    public bool IsHidden() {
        return this.hidden;
    }

    public string GetRenderedText() {
        if (this.hidden) {
            return new string('_', this.text.Length);
        }
        return this.text;
    }
}