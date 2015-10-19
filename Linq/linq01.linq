<Query Kind="Expression">
  <Connection>
    <ID>cd3b10a5-1eda-441a-ad17-f60dc88c30b8</ID>
    <Persist>true</Persist>
    <Server>localhost</Server>
    <Database>AdventureWorks2012</Database>
    <IncludeSystemObjects>true</IncludeSystemObjects>
  </Connection>
</Query>

from person in Persons
group person by person.FirstName into g
orderby g.Count()
select new { FirstName = g.First().FirstName, Count = g.Count() } 


