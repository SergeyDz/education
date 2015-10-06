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
let p = person 
let name = p.LastName + ", " + p.FirstName
where name.Contains("A")
select name