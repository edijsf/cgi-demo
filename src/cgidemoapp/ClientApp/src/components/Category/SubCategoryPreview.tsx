import React from "react";

interface Props {}

const SubCategoryPreview = (props: Props) => {
  return (
    <div className="subcategory-preview">
      <div className="subcategory-thumbnail" />
      <div
        style={{
          display: "flex",
          flexDirection: "column",
          gap: "5px",
        }}
      >
        <div className="subcategory-text"></div>
        <div className="subcategory-text"></div>
      </div>
    </div>
  );
};

export default SubCategoryPreview;
