import React from "react";

interface Props {
  children?: React.ReactNode;
}

const index = ({ children }: Props) => {
  return <div className="main">{children}</div>;
};

export default index;
