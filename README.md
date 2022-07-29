# Tasks

## Backend Tasks
1. Be able retrieve hierarchial data for categories and acessible to frontend
  Be aware of reused categories as Categories have many to many relationship 
2. Be able to retrieve product by category
  Parent category should be able to list product from nested categories
    eg. if parent category has 1 product and subcategory have 1 product, parent category should be able to get both products
  Be aware products can be assigned to multiple categories
  If category and subcategories have same product backend should return only 1 product 
3. Use of repository pattern is a bonus
4. Use of CQRS pattern is bonus
