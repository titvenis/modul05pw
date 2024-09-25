public interface IDocument {
    void Open();
}

public class Report : IDocument {
    public void Open() {
        Console.WriteLine("Opening Report");
    }
}

public class Resume : IDocument {
    public void Open() {
        Console.WriteLine("Opening Resume");
    }
}

public class Letter : IDocument {
    public void Open() {
        Console.WriteLine("Opening Letter");
    }
}

public interface IDocumentCreator {
    IDocument CreateDocument();
}

public class ReportCreator : IDocumentCreator {
    public IDocument CreateDocument() {
        return new Report();
    }
}

public class ResumeCreator : IDocumentCreator {
    public IDocument CreateDocument() {
        return new Resume();
    }
}

public class LetterCreator : IDocumentCreator {
    public IDocument CreateDocument() {
        return new Letter();
    }
}



public class Invoice : IDocument {
    public void Open() {
        Console.WriteLine("Opening Invoice");
    }
}

    public class InvoiceCreator : IDocumentCreator {
    public IDocument CreateDocument() {
        return new Invoice();
    }
}


public class DynamicDocumentFactory {
    public DocumentCreator GetDocumentCreator(string type) {
        if (type == "report") {
            return new ReportCreator();
        } else if (type == "resume") {
            return new ResumeCreator();
        } else if (type == "letter") {
            return new LetterCreator();
        } else if (type == "invoice") {
            return new InvoiceCreator();
        } else {
            throw new ArgumentException("Error");
        }
    }           
}
