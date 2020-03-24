select a.Topic, t.Name as Tag from Article a 
left join Repository r on a.Id = r.ArticleId
 left join Tag t on r.TagId= t.Id