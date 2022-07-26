# Tasks

## Backend Tasks

1. Be able retrieve hierarchial data for categories and acessible to frontend
   - Be aware of reused categories as Categories have many to many relationship
2. Be able to retrieve product by category
   - Parent category should be able to list product from nested categories
   - eg . if parent category has 1 product and subcategory have 1 product, parent category should be able to get both products
   - Be aware products can be assigned to multiple categories
   - If category and subcategories have same product backend should return only 1 product
3. Be able to retrieve promoted categories
4. Use of repository pattern is a bonus
5. Use of CQRS pattern is bonus

## Frontend Tasks

design: https://www.figma.com/file/7PT8s0RCyt99TgL5JEqmE8/CGI-Demo?node-id=0%3A1

1. Center text in pages/404.tsx
2. Refactor Header component so its readable, consistent & works correctly (logo should go to root, links should go to 404)
3. Recreate design from Figma
4. Access and display products from backend
5. Access and display promoted categories from backend
6. Access and display hierarchial categories data from backend
7. Bonus:
   - Categories side navigation opens and closes from user click
   - Show promoted products ribbon
   - Clicking Add to cart button should increase the cart items counter in Header.tsx
   - One of the developers will love your code if you use tailwind.css
