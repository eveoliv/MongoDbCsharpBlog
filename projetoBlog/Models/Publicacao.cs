﻿using System;
using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace projetoBlog.Models
{
    public class Publicacao
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public List<string> Tags { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}