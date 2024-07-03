################################################################################
# Program: prepare_data.r
# Author:  @Nekhaevalex
# Purpose: Prepares data for Lab 1.1.1
# Input:   Лаба 1.1.1.xlsx
# Output:  experimental.diameter
#          experimental.current
#          meta.accuracy
#          meta.characteristics
################################################################################

# Loading dependencies
library(tidyverse)
library(sassy)
library(readxl)

# Enabling logging
log_open(
    "./Physics_Labs/1_sem/Lab111/rmarkdown/preparation.log",
    autolog = TRUE,
    show_notes = TRUE
)

put("Setting up library")

# Setting up library
libname(experimental, "./Physics_Labs/1_sem/Lab111/rmarkdown/data/experimental")
libname(meta, "./Physics_Labs/1_sem/Lab111/rmarkdown/data/meta")

source_data <- "./Physics_Labs/1_sem/Lab111/Лаба 1.1.1.xlsx"

put("Preparing DIAMETER dataset")

experimental$diameter <-
    read_excel(
        source_data,
        sheet = "Sheet1",
        range = "C15:L17"
    ) |>
    proc_transpose() |>
    rename(D1 = COL1, D2 = COL2) |>
    select(c(D1, D2)) |>
    datastep(
        attrib = list(
            D1 = dsattr(label = "Диаметр 1, мм"),
            D2 = dsattr(label = "Диаметр 2, мм")
        ), {}
    )

current_import <-
    function(group, range) {
        df <-
            read_excel(
                source_data,
                sheet = "Sheet1",
                range = range
            ) |>
            mutate(
                group = group
            )
        colnames(df) <- c("Vdel", "Idel", "V", "I", "group")
        return(df)
    }

put("Preparing CURRENT dataset")

experimental$current <-
    bind_rows(
        list(
            current_import("20", "B32:E44"),
            current_import("30", "F32:I44"),
            current_import("50", "J32:M44")
        )
    ) |>
    rename(
        length = group
    ) |>
    mutate(
        V = Vdel * 10
    ) |>
    select(-c(Idel)) |>
    datastep(
        attrib = list(
            length = dsattr(label = "Длина провода, cm"),
            Vdel = dsattr(label = "V, дел, 1мВ/дел"),
            V = dsattr(label = "V, мВ"),
            I = dsattr(label = "I, мА")
        ), {}
    )

experimental$bridge <-
    read_excel(
        source_data,
        sheet = "Sheet1",
        range = "B47:G48"
    ) |>
    proc_transpose() |>
    mutate(
        NAME = case_when(
            NAME == "...2" ~ 20,
            NAME == "...4" ~ 30,
            NAME == "...6" ~ 50
        )
    ) |>
    rename(
        length = NAME,
        r0 = COL1
    )

put("Preparing ACCURACY dataset")

meta$accuracy <-
    read_excel(
        source_data,
        sheet = "Sheet1",
        range = "B10:C12"
    ) |>
    rename(
        "tool" = "Прибор",
        "accuracy" = "Точность"
    ) |>
    datastep(
        attrib = list(
            tool = dsattr(label = "Прибор"),
            accuracy = dsattr(label = "Точность")
        ), {}
    )

put("Preparing CHARACTERISTICS dataset")

meta$characteristics <-
    read_excel(
        source_data,
        sheet = "Sheet1",
        range = "N3:P11"
    ) |>
    rename(
        "parameter" = "Параметр",
        "voltmeter" = "Вольтметр",
        "milliammeter" = "Миллиамперметр"
    ) |>
    datastep(
        attrib = list(
            parameter = dsattr(label = "Параметр"),
            voltmeter = dsattr(label = "Вольтметр"),
            milliammeter = dsattr(label = "Миллиамперметр")
        ), {}
    )

put("Writing datasets")

lib_write(experimental)
lib_write(meta)

log_close()