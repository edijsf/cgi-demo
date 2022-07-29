import React from "react";
import "./Products.css";

interface Props {}

const ProductsSort = (props: Props) => {
  return (
    <div className="products-sort">
      <div className="sort-option"></div>
      <div className="sort-option"></div>
      <div className="sort-option"></div>
      <div className="sort-option"></div>
    </div>
  );
};

export default ProductsSort;
