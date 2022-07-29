import React from "react";
import SubCategoryPreview from "./SubCategoryPreview";
import "./CategoryHeader.css";

interface Props {}

const CategoryHeader = (props: Props) => {
  return (
    <div className="categoryheader">
      <h5>Garden and Recreation</h5>
      <h3>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum
        lacus quam, commodo vel arcu vel.
      </h3>
      <div className="subcategory-preview-wrapper">
        <SubCategoryPreview />
        <SubCategoryPreview />
        <SubCategoryPreview />
        <SubCategoryPreview />
        <SubCategoryPreview />
      </div>
    </div>
  );
};

export default CategoryHeader;
