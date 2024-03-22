import { Container, Stack, Typography } from "@mui/material";
import React from "react";
import { SearchResult } from "./search-result";
import { Searcher } from "./searcher";

export const SearchContainer = () => {
  return (
    <Container maxWidth="xl">
      <Stack direction="row" alignItems="center" justifyContent="space-between" mb={5}>
        <Typography variant="h4">Search</Typography>
      </Stack>
      <Searcher />
      <SearchResult />
    </Container>
  );
};
