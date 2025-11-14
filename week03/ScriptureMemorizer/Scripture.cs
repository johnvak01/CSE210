using System.Collections.Generic;
public class Scripture{
    private string _reference;
    private List<Word> _content; 

    public Scripture(string reference, string content){
        _reference = reference;
        _content = [];
        string[] contentList = content.Split(' ');
        for(int x = 0; x < contentList.Count();x++){
            Word new_word = new Word(contentList[x]);
            _content.Add(new_word);
        }
    }
    public void HideRandomWord(){
        Random numgen = new Random();
        while(true){
            int selection = numgen.Next(0,_content.Count-1);
            if(_content[selection].GetVisibility() == true){
                _content[selection].ToggleVisibility();
                break;
            }
        }
    }
    public string Display(){
        string output = _reference + "\t";
        foreach(Word term in _content){
            output += term.GetContent()+" ";
        }
        return output;
    }
}