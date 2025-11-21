using System.Collections.Generic;
using System.Reflection;
public class Video{
    string _title, _author;
    int _length;
    List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> comments){
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public string DisplayVideo(){
        return $"{_title} - by: {_author}\nLength:\t{_length}s";
    }
    public string DisplayComments(){
        string output = "";
        for (int x = 0; x<_comments.Count;x++){
            output  +=  _comments[x].Display()+"\n";
        }
        return output;
    }
    public int TotalComments(){
        return _comments.Count;
    }

}