using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;

namespace TheArt.Models
{
  public class Piece
  {
    
    public int PieceId { get; set; }
    [DisplayName("Piece Name")]
    public string PieceName { get; set; }
    [DisplayName("Date Piece was Created")]
    public DateTime PieceDate { get; set; }
    public byte[] PieceImage { get; set; }
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
    
  }
}