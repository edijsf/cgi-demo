import React from "react";
import Product from "./Product";
import "./ProductsList.css";

interface Props {}

const ProductsList = (props: Props) => {
  return (
    <div className="products-list">
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
    </div>
  );
};

export default ProductsList;
